using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardManager
{
    public partial class frmFlickr : Form
    {
        public string filename;
        public frmFlickr(string filename)
        {
            this.filename = filename;
            InitializeComponent();
        }

        private void frmFlickr_Load(object sender, EventArgs e)
        {
            flickrFile.Text = filename;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            FlickrManager.UploadPicture(filename, flickrTitle.Text, flickrDescription.Text, flickrPublic.Checked);
            this.Close();
        }
    }
}
