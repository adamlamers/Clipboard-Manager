using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;

namespace ClipboardManager
{
    public partial class frmPreferences : Form
    {
        public frmPreferences()
        {
            InitializeComponent();
        }
        public string sShowBalloonTips;
        public string sUploadScreenshots;
        public string sImageFormat;

        public string strReadConfigValue(string element)
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.ini");
            XmlNodeList xnlReturnConfigValue = config.GetElementsByTagName(element);
            string returnConfigValue = xnlReturnConfigValue[0].InnerText;
            return returnConfigValue;
        }

        public bool boolReadConfigValue(string element)
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.ini");
            XmlNodeList xnlReturnConfigValue = config.GetElementsByTagName(element);
            bool returnConfigValue = false;
            if (xnlReturnConfigValue[0].InnerText == "1")
                returnConfigValue = true;
            else
                returnConfigValue = false;
            return returnConfigValue;
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader configReader = new System.IO.StreamReader("config.ini");
            ssStorageDir.Text = strReadConfigValue("ssStorageDir");

            showBalloonTips.Checked = boolReadConfigValue("BalloonTips");

            if (strReadConfigValue("ImageFormat") == "jpg")
            {
                selectImageFormat.SelectedIndex = 0;
            }
            else if (strReadConfigValue("ImageFormat") == "png")
            {
                selectImageFormat.SelectedIndex = 1;
            }
            else if (strReadConfigValue("ImageFormat") == "bmp")
            {
                selectImageFormat.SelectedIndex = 2;
            }

            ssUpload.Checked = boolReadConfigValue("UploadScreenshots");
            flickrUpload.Checked = boolReadConfigValue("FlickrUpload");

            ftpServer.Text = strReadConfigValue("FTPServer");
            ftpUsername.Text = strReadConfigValue("Username");
            ftpPassword.Text = strReadConfigValue("Password");

            flickruser.Text = strReadConfigValue("FlickrUsername");
            flickrauthtoken.Text = strReadConfigValue("FlickrAuthToken");
            FlickrManager.authenticatedUsername = strReadConfigValue("FlickrUsername");
            FlickrManager.authToken = strReadConfigValue("FlickrAuthToken");

            configReader.Close();
        }

        private void cancelConfig_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            string cFlickrUpload;

            if(showBalloonTips.Checked == true)
                sShowBalloonTips = "1";
            else
                sShowBalloonTips = "0";

            if (ssUpload.Checked == true)
                sUploadScreenshots = "1";
            else
                sUploadScreenshots = "0";

            if(flickrUpload.Checked)
                cFlickrUpload = "1";
            else
                cFlickrUpload = "0";

            if (selectImageFormat.SelectedIndex == 0)
                sImageFormat = "jpg";
            else if (selectImageFormat.SelectedIndex == 1)
                sImageFormat = "png";
            else if (selectImageFormat.SelectedIndex == 2)
                sImageFormat = "bmp";
            try
            {
                StreamWriter configStream = new StreamWriter("config.ini");
                configStream.WriteLine("<config>");
                configStream.WriteLine("\t<ssStorageDir>" + ssStorageDir.Text + "</ssStorageDir>");
                configStream.WriteLine("\t<BalloonTips>" + sShowBalloonTips + "</BalloonTips>");
                configStream.WriteLine("\t<ImageFormat>" + sImageFormat + "</ImageFormat>");
                configStream.WriteLine("\t<UploadScreenshots>" + sUploadScreenshots + "</UploadScreenshots>");
                configStream.WriteLine("\t<FTPServer>" + ftpServer.Text + "</FTPServer>");
                configStream.WriteLine("\t<Username>" + ftpUsername.Text + "</Username>");
                configStream.WriteLine("\t<Password>" + ftpPassword.Text + "</Password>");
                configStream.WriteLine("\t<FlickrUpload>" + cFlickrUpload + "</FlickrUpload>");
                configStream.WriteLine("\t<FlickrUsername>" + FlickrManager.authenticatedUsername + "</FlickrUsername>");
                configStream.WriteLine("\t<FlickrAuthToken>" + FlickrManager.authToken + "</FlickrAuthToken>");
                configStream.WriteLine("</config>");
                configStream.Close();
                ConfigManager.SetConfigValues();
                Close();
            }
            catch(Exception error)
            {
              MessageBox.Show(error.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ssStorageDirBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog selectFile = new FolderBrowserDialog();
            if (selectFile.ShowDialog() == DialogResult.OK)
            {
                ssStorageDir.Text = selectFile.SelectedPath;
            }

        }

        private void openAuth_Click(object sender, EventArgs e)
        {
            FlickrManager.OpenAuthURL();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlickrManager.CompleteAuthentication();
            flickruser.Text = FlickrManager.authenticatedUsername;
            flickrauthtoken.Text = FlickrManager.authToken;
            ErrorLabel.Text = FlickrManager.errorMessage;
            successMessage.Text = FlickrManager.successMessage;
        }
    }
}
