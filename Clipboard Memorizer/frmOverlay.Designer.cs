namespace ClipboardManager
{
    partial class frmOverlay
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
            try
            {
                base.Dispose(disposing);
            }
            catch
            {
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFTPUpload = new System.Windows.Forms.Button();
            this.btnFlickrUpload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFTPUpload
            // 
            this.btnFTPUpload.Location = new System.Drawing.Point(76, 448);
            this.btnFTPUpload.Name = "btnFTPUpload";
            this.btnFTPUpload.Size = new System.Drawing.Size(62, 40);
            this.btnFTPUpload.TabIndex = 1;
            this.btnFTPUpload.Text = "FTP Upload";
            this.btnFTPUpload.UseVisualStyleBackColor = true;
            // 
            // btnFlickrUpload
            // 
            this.btnFlickrUpload.Location = new System.Drawing.Point(144, 448);
            this.btnFlickrUpload.Name = "btnFlickrUpload";
            this.btnFlickrUpload.Size = new System.Drawing.Size(62, 40);
            this.btnFlickrUpload.TabIndex = 2;
            this.btnFlickrUpload.Text = "Flickr Upload";
            this.btnFlickrUpload.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImage = global::ClipboardManager.Properties.Resources.wtf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFlickrUpload);
            this.Controls.Add(this.btnFTPUpload);
            this.Controls.Add(this.btnSave);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOverlay";
            this.Text = "frmOverlay";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.frmOverlay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFTPUpload;
        private System.Windows.Forms.Button btnFlickrUpload;
        private System.Windows.Forms.Button btnCancel;




    }
}