namespace ClipboardManager
{
    partial class frmFlickr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlickr));
            this.flickrFilelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flickrTitle = new System.Windows.Forms.TextBox();
            this.flickrDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uploadImage = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.flickrFile = new System.Windows.Forms.Label();
            this.flickrPublic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // flickrFilelabel
            // 
            this.flickrFilelabel.AutoSize = true;
            this.flickrFilelabel.Location = new System.Drawing.Point(12, 9);
            this.flickrFilelabel.Name = "flickrFilelabel";
            this.flickrFilelabel.Size = new System.Drawing.Size(80, 13);
            this.flickrFilelabel.TabIndex = 0;
            this.flickrFilelabel.Text = "Uploading File: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image Title:";
            // 
            // flickrTitle
            // 
            this.flickrTitle.Location = new System.Drawing.Point(120, 40);
            this.flickrTitle.Name = "flickrTitle";
            this.flickrTitle.Size = new System.Drawing.Size(489, 20);
            this.flickrTitle.TabIndex = 2;
            // 
            // flickrDescription
            // 
            this.flickrDescription.AutoSize = true;
            this.flickrDescription.Location = new System.Drawing.Point(12, 82);
            this.flickrDescription.Name = "flickrDescription";
            this.flickrDescription.Size = new System.Drawing.Size(95, 13);
            this.flickrDescription.TabIndex = 3;
            this.flickrDescription.Text = "Image Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(489, 126);
            this.textBox1.TabIndex = 4;
            // 
            // uploadImage
            // 
            this.uploadImage.Location = new System.Drawing.Point(120, 231);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(131, 23);
            this.uploadImage.TabIndex = 5;
            this.uploadImage.Text = "Upload Image to Flickr";
            this.uploadImage.UseVisualStyleBackColor = true;
            this.uploadImage.Click += new System.EventHandler(this.uploadImage_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(534, 231);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // flickrFile
            // 
            this.flickrFile.AutoSize = true;
            this.flickrFile.Location = new System.Drawing.Point(117, 9);
            this.flickrFile.Name = "flickrFile";
            this.flickrFile.Size = new System.Drawing.Size(0, 13);
            this.flickrFile.TabIndex = 7;
            // 
            // flickrPublic
            // 
            this.flickrPublic.AutoSize = true;
            this.flickrPublic.Location = new System.Drawing.Point(120, 208);
            this.flickrPublic.Name = "flickrPublic";
            this.flickrPublic.Size = new System.Drawing.Size(147, 17);
            this.flickrPublic.TabIndex = 8;
            this.flickrPublic.Text = "Upload as a Public Image";
            this.flickrPublic.UseVisualStyleBackColor = true;
            // 
            // frmFlickr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 264);
            this.Controls.Add(this.flickrPublic);
            this.Controls.Add(this.flickrFile);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.uploadImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flickrDescription);
            this.Controls.Add(this.flickrTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flickrFilelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFlickr";
            this.Text = "Uploading to Flickr";
            this.Load += new System.EventHandler(this.frmFlickr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label flickrFilelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flickrTitle;
        private System.Windows.Forms.Label flickrDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button uploadImage;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label flickrFile;
        private System.Windows.Forms.CheckBox flickrPublic;
    }
}