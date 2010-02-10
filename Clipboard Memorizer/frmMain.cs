//Adam Lamers
//Clipboard Memorizer
//Date: 4/8/2009
//Last Modified: 4/10/2009

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net;

namespace ClipboardManager
{
    public partial class frmMain : Form
    {

        //Variable Declarations
        #region VARIABLE DECLARATIONS

        public string sessionStartTime = "";
        public string fileName = "";
        Stack<string> ssQueue = new Stack<string>();
        Stack<string> cbQueue = new Stack<string>();
        Queue<string> cbData = new Queue<string>(5);
        string[]      cbArray = new string[1000];
        public bool formvisible = true;
        public int numWrites = 0;
        public int numTries = 0;

        public int numSS = 0;
        string ssFileName = "";
        FileInfo ssFileInfo;
        

        public int uploadStatus = 0;

        #endregion

        public frmMain()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                cbArray[i] = "";
            }
        }

        public void ToggleVisible()
        {
            if (formvisible == true)
            {
                Hide();
                WindowState = FormWindowState.Minimized;
                nIcon1.Visible = true;
                formvisible = false;
            }
            else
            {
                Show();
                WindowState = FormWindowState.Normal;
                nIcon1.Visible = false;
                formvisible = true;
            }
        }

        public void ArchiveSessionStart()
        {
            sessionStartTime = DateTime.Now.ToString("MM/dd/yy h:m:ss");
            fileName = DateTime.Now.ToString("yyyy-MMM-dd_hh_mm_fff") + ".txt";
            archiveFileName.Text = "Archive File: " + fileName;
            sessionStart.Text = "Session Started: " + sessionStartTime;
        }

        public string ConvertBytes(long size)
        {
            long KB = 1024;
            long MB = (int)Math.Pow((double)1024, (double)2);
            long GB = (int)Math.Pow((double)1024, (double)3);
            long TB = (int)Math.Pow((double)1024, (double)4);
            long PB = (int)Math.Pow((double)1024, (double)5);

            if (size > KB)
                return size / KB + "KB";
            else if (size > MB)
                return size / MB + "MB";
            else if (size > GB)
                return size / GB + "GB";
            else if (size > TB)
                return size / TB + "TB";
            else
                return size / PB + "PB";
        }
  
        private ImageCodecInfo getEncoderInfo(string mimeType)
        {
           // Get image codecs for all image formats
           ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

           // Find the correct image codec
           for (int i = 0; i < codecs.Length; i++)
              if (codecs[i].MimeType == mimeType)
                 return codecs[i];
           return null;
        }

        public void WriteError(string message)
        {
            StreamWriter errorlog = new StreamWriter("error.log", true);
            errorlog.Write(message + Environment.NewLine + Environment.NewLine);
            errorlog.Close();
        }
     
        public int UploadFile(string filename, string ftpServer, string username, string password)
        {
            //ERROR CODES
            // -1 - Invalid FTP Server
            // -2 - Invalid FTP Credentials
                try
                {
                    DateTime startTime = DateTime.Now;
                    DateTime curTime = new DateTime();
                    TimeSpan speedTime = new TimeSpan();
                    FileInfo info = new FileInfo(filename);
                    FtpWebRequest request = null;
                    request = (FtpWebRequest)WebRequest.Create(ftpServer + info.Name);
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(username, password);
                    request.KeepAlive = true;
                    request.ContentLength = info.Length;
                    FtpWebResponse Response = null;
                    Response = (FtpWebResponse)request.GetResponse();
                    FileStream fs = info.OpenRead();
         
                    int bufferLen = 2048;
                    byte[] buffer = new byte[bufferLen];
                    int contentLen;
                    int uploadSpeed = 0;
                    float contentDone = 0;
                    float percentDone = 0;
                    int uploadStatus = 0;
                    Stream stream = request.GetRequestStream();
                    contentLen = fs.Read(buffer, 0, bufferLen);
                    tsStatus.Text = "Uploading";
                    queueStatusLabel.Text = "Items in Queue - " + ssQueue.Count.ToString();
                    startTime = DateTime.Now;
                    while (contentLen != 0)
                    {
                        stream.Write(buffer, 0, contentLen);
                        contentLen = fs.Read(buffer, 0, bufferLen);
                        uploadStatus = uploadStatus + 1;
                        contentDone += contentLen;
                        percentDone = (contentDone / (float)info.Length)*100;
                        uploadWorker.ReportProgress((int)percentDone);
                        //Calculate Time and speed of the upload
                        curTime = DateTime.Now;
                        speedTime = curTime.Subtract(startTime);
                        uploadSpeed = (int)((contentDone / speedTime.Seconds) / 1024);
                        if (uploadSpeed > 0)
                            speedLabel.Text = uploadSpeed.ToString() + "KB/s";
                        else
                            speedLabel.Text = "0 KB/s";
                    }
                    uploadWorker.ReportProgress(100);
                    uploadWorker.ReportProgress(0);
                    tsStatus.Text = "Upload Complete";
                    speedLabel.Text = "";
                    stream.Close();
                    fs.Close();
                    Response.Close();
                    return 1;
                }
                catch(Exception e)
                {
                    if (numTries < 5)
                    {
                        tsStatus.Text = "FTP Upload Error - Retrying";
                        ssQueue.Push(filename);
                        numTries++;
                    }
                    else
                    {
                        tsStatus.Text = "FTP Upload Failed 5 Times - Stopped Retries";
                        WriteError(e.ToString());
                    }
                    return -1;
                }
         }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                formvisible = false;
                nIcon1.Visible = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Checking for duplicate processes, so more than one program is not running at a time.
            if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("Clipboard Memorizer is already running.", "Already Running", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
            }

            //Check if config.ini exists, if not write a new one with default values.
            if (!File.Exists("config.ini"))
            {
                ConfigManager.WriteNewConfig();
                ConfigManager.SetConfigValues();
            }
            else
            {
                ConfigManager.SetConfigValues();
            }

            //Check for or create archives and screenshot directories
            if (!Directory.Exists("archives/"))
                Directory.CreateDirectory("archives/");
            if (!Directory.Exists("screenshots/"))
                Directory.CreateDirectory("screenshots/");

            ArchiveSessionStart();
            tHotkey.Start();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (uploadWorker.IsBusy)
            {
                uploadWorker.CancelAsync();
            }
        }

        private void nIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ToggleVisible();
        }

        private void tHotkey_Tick(object sender, EventArgs e)
        {
            if (numSS == 0) noscrnshots.Visible = true; else noscrnshots.Visible = false;
            if (Clipboard.ContainsText())
            {
                if (!cbArray.Contains(Clipboard.GetText()))
                {
                    numWrites++;
                    if (ConfigManager.BalloonTips) nIcon1.ShowBalloonTip(1000, "Clipboard Saved", Clipboard.GetText(), ToolTipIcon.Info);
                    StreamWriter archiveWriter = new StreamWriter("archives/" + fileName, true);
                    archiveWriter.Write("#####REGION" + numWrites.ToString() + "\r\n" + Clipboard.GetText() + Environment.NewLine + "#####ENDREGION" + numWrites.ToString() + Environment.NewLine);
                    archiveWriter.Close();

                    cbData.Enqueue(Clipboard.GetText());
                    cbArray = cbData.ToArray();
                    if (cbArray.Length > 0)
                    {
                        clipboardData0.Text = cbArray[cbArray.Length - 1];
                        toolTip1.SetToolTip(clipboardData0, cbArray[cbArray.Length - 1]);
                    }
                    if (cbArray.Length > 1)
                    {
                        clipboardData1.Text = cbArray[cbArray.Length - 2];
                        toolTip1.SetToolTip(clipboardData1, cbArray[cbArray.Length - 2]);
                    }
                    if (cbArray.Length > 2)
                    {
                        clipboardData2.Text = cbArray[cbArray.Length - 3];
                        toolTip1.SetToolTip(clipboardData2, cbArray[cbArray.Length - 3]);
                    }
                    if (cbArray.Length > 3)
                    {
                        clipboardData3.Text = cbArray[cbArray.Length - 4];
                        toolTip1.SetToolTip(clipboardData3, cbArray[cbArray.Length - 4]);
                    }
                    if (cbArray.Length > 4)
                    {
                        clipboardData4.Text = cbArray[cbArray.Length - 5];
                        toolTip1.SetToolTip(clipboardData4, cbArray[cbArray.Length - 5]);
                    }
                }
            }
            if (GetAsyncKeyState(Keys.PrintScreen) != 0)
            {
                if (Clipboard.ContainsImage())
                {
                    if (ConfigManager.ssImageFormat == "")
                        ConfigManager.ssImageFormat = "jpg";
                    numSS++;
                    ssFileName = DateTime.Now.ToString("yyyy-MMM-dd_hh_mm_fff") + "."+ConfigManager.ssImageFormat;

                    Bitmap ClipboardImage = new Bitmap(Clipboard.GetImage());
                    Bitmap DisplayImage = new Bitmap(ClipboardImage, new Size(338, 153));
                    ss.Image = DisplayImage;

                    if (ConfigManager.flickrUpload)
                        new frmFlickr(ssFileName).Show();

                    if (ConfigManager.ssImageFormat == "bmp")
                        ClipboardImage.Save(ConfigManager.ssStorageDir + "\\" + ssFileName);
                    else if (ConfigManager.ssImageFormat == "jpg")
                        ClipboardImage.Save(ConfigManager.ssStorageDir + "\\" + ssFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    else if (ConfigManager.ssImageFormat == "png")
                        ClipboardImage.Save(ConfigManager.ssStorageDir + "\\" + ssFileName, System.Drawing.Imaging.ImageFormat.Png);
                    if(ConfigManager.BalloonTips) nIcon1.ShowBalloonTip(2000, "Screenshot Saved", "Saved As: " + ConfigManager.ssStorageDir + "\\" + ssFileName, ToolTipIcon.Info);
                    cbData.Enqueue("Screenshot: " + ssFileName);
                    if (ConfigManager.ssUpload)
                    {
                        ssQueue.Push(ConfigManager.ssStorageDir + "\\" + ssFileName);
                        queueStatusLabel.Text = "Items in Queue - " + ssQueue.Count().ToString();
                    }
                    ssFileInfo = new FileInfo(ConfigManager.ssStorageDir + "\\" + ssFileName);
                    ssInfo.Text = "Filename: " + ssFileName + " Size: " + ConvertBytes(ssFileInfo.Length);
                }
            }
            if (ssQueue.Count() > 0)
            {
                if (!uploadWorker.IsBusy)
                {
                    uploadWorker.RunWorkerAsync();
                }
            }
        }

        private void mswlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.millenniumsoftworks.com");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPreferences().Show();
        }

        private void ss_Click(object sender, EventArgs e)
        {
            if (numSS > 0)
            {
                System.Diagnostics.Process.Start(ConfigManager.ssStorageDir + "\\" + ssFileName);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAbout().Show();
        }

        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchiveSessionStart();
            tsStatus.Text = "New Session Started";
        }

        private void uploadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string ssLocation = ConfigManager.ssStorageDir + "\\" + ssFileName;
            UploadFile(ssQueue.Pop(), ConfigManager.ssFTPServer, ConfigManager.ssUsername, ConfigManager.ssPassword);
        }

        private void uploadWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void clearUploadQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ssQueue.Clear();
            queueStatusLabel.Text = "Items in Queue - " + ssQueue.Count.ToString();
        }

        private void cancelCurrentUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uploadWorker.IsBusy)
            {
                uploadWorker.CancelAsync();
            }
        }

        private void copy0_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(clipboardData0.Text);
        }

        private void copy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(clipboardData1.Text);
        }

        private void copy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(clipboardData2.Text);
        }

        private void copy3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(clipboardData3.Text);
        }

        private void copy4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(clipboardData4.Text);
        }

        private void screenInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmScreenInfo().Show();
        }
    }
}
