using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ClipboardManager
{
    public partial class frmOverlay : Form
    {
        bool drawingCutRect = false;
        bool screenShotTaken = false;
        Point mouseDownCoords;
        public Rectangle cutrect;
        Pen drawPen = new Pen(Color.Red, 2);
        Graphics graphics;
        public string ssFileName;
        Bitmap image;

        public frmOverlay()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(frmOverlay_MouseDown);
            this.MouseMove += new MouseEventHandler(frmOverlay_MouseMove);
            this.MouseUp += new MouseEventHandler(frmOverlay_MouseUp);
            this.KeyDown += new KeyEventHandler(frmOverlay_KeyDown);
            this.FormClosing += new FormClosingEventHandler(frmOverlay_FormClosing);
        }

        void frmOverlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            graphics.Clear(Color.LightPink);
            btnCancel.Visible = false;
            btnFlickrUpload.Visible = false;
            btnFTPUpload.Visible = false;
            btnSave.Visible = false;

            if (!screenShotTaken)
            {
                ssFileName = "screenshots\\" + DateTime.Now.ToString("yyyy-MMM-dd_hh_mm_fff") + "." + ConfigManager.ssImageFormat;
                TakeScreenShot(this.cutrect).Save(ssFileName);
            }
            screenShotTaken = true;
        }

        public static Bitmap TakeScreenShot(Rectangle shotRect)
        {
            Bitmap screenshot = new Bitmap(shotRect.Width, shotRect.Height);
            Graphics screenshotfromscreen = Graphics.FromImage(screenshot);
            screenshotfromscreen.CopyFromScreen(shotRect.X, shotRect.Y, 0, 0, shotRect.Size, CopyPixelOperation.SourceCopy);
            return screenshot;
        }

        void frmOverlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        void frmOverlay_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawingCutRect)
            {
                
                btnSave.Location = new Point(cutrect.X + 5, cutrect.Y + cutrect.Height - btnCancel.Height - 5);
                btnSave.Visible = true;

                btnFTPUpload.Location = new Point(cutrect.X + 5 + btnFTPUpload.Width, cutrect.Y + cutrect.Height - btnCancel.Height - 5);
                btnFTPUpload.Visible = true;

                btnFlickrUpload.Location = new Point(cutrect.X + 5 + btnFlickrUpload.Width * 2, cutrect.Y + cutrect.Height - btnCancel.Height - 5);
                btnFlickrUpload.Visible = true;
                
                btnCancel.Location = new Point(cutrect.X + 5 + btnCancel.Width * 3, cutrect.Y + cutrect.Height - btnCancel.Height - 5);
                btnCancel.Visible = true;
                
                graphics.Clear(Color.LightPink);
                graphics.DrawRectangle(drawPen, cutrect);
                drawingCutRect = false;
            }
        }

        void frmOverlay_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingCutRect)
            {
                graphics.Clear(Color.LightPink);
                graphics.DrawRectangle(drawPen, cutrect);
                cutrect = new Rectangle(mouseDownCoords, new Size(e.X - mouseDownCoords.X, e.Y - mouseDownCoords.Y));
            }
        }

        void frmOverlay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawingCutRect = true;
                mouseDownCoords = new Point(e.X, e.Y);
            }
        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        private void frmOverlay_Load(object sender, EventArgs e)
        {
            Bitmap backgroundImage = TakeScreenShot(new Rectangle(0, 0, 2880, 900));
            image = backgroundImage;
            this.Width = 2880;
            this.Height = 900;
            this.Location = new Point(0, 0);
            this.BackgroundImage = backgroundImage;
            graphics = this.CreateGraphics();
            btnCancel.Visible = false;
            btnFlickrUpload.Visible = false;
            btnFTPUpload.Visible = false;
            btnSave.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}
