namespace ClipboardManager
{
    partial class frmPreferences
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreferences));
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.selectImageFormat = new System.Windows.Forms.ComboBox();
            this.showBalloonTips = new System.Windows.Forms.CheckBox();
            this.ssStorageDir = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveConfig = new System.Windows.Forms.Button();
            this.cancelConfig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabPrefs = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.ssStorageDirBrowse = new System.Windows.Forms.Button();
            this.ssstoragedirlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FTPOptions = new System.Windows.Forms.TabPage();
            this.ssUpload = new System.Windows.Forms.CheckBox();
            this.ftpPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ftpUsername = new System.Windows.Forms.TextBox();
            this.ftpServer = new System.Windows.Forms.TextBox();
            this.FlickrPrefs = new System.Windows.Forms.TabPage();
            this.successMessage = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.flickrauthtoken = new System.Windows.Forms.Label();
            this.flickruser = new System.Windows.Forms.Label();
            this.flickrUpload = new System.Windows.Forms.CheckBox();
            this.openAuth = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TabPrefs.SuspendLayout();
            this.General.SuspendLayout();
            this.FTPOptions.SuspendLayout();
            this.FlickrPrefs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tTip
            // 
            this.tTip.ShowAlways = true;
            // 
            // selectImageFormat
            // 
            this.selectImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectImageFormat.FormattingEnabled = true;
            this.selectImageFormat.Items.AddRange(new object[] {
            "jpg",
            "png",
            "bmp"});
            this.selectImageFormat.Location = new System.Drawing.Point(176, 80);
            this.selectImageFormat.Name = "selectImageFormat";
            this.selectImageFormat.Size = new System.Drawing.Size(121, 21);
            this.selectImageFormat.TabIndex = 4;
            this.tTip.SetToolTip(this.selectImageFormat, "Select the image format you want your screenshots to be saved in.");
            // 
            // showBalloonTips
            // 
            this.showBalloonTips.AutoSize = true;
            this.showBalloonTips.Location = new System.Drawing.Point(10, 54);
            this.showBalloonTips.Name = "showBalloonTips";
            this.showBalloonTips.Size = new System.Drawing.Size(114, 17);
            this.showBalloonTips.TabIndex = 3;
            this.showBalloonTips.Text = "Show Balloon Tips";
            this.tTip.SetToolTip(this.showBalloonTips, "Enables or Disables balloon tips showing in the tray when Clipboard Memorizer tak" +
                    "es action.");
            this.showBalloonTips.UseVisualStyleBackColor = true;
            // 
            // ssStorageDir
            // 
            this.ssStorageDir.Location = new System.Drawing.Point(10, 22);
            this.ssStorageDir.Name = "ssStorageDir";
            this.ssStorageDir.Size = new System.Drawing.Size(255, 20);
            this.ssStorageDir.TabIndex = 1;
            this.tTip.SetToolTip(this.ssStorageDir, "The directory your screenshots will be saved to.");
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(160, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Complete Authentication";
            this.tTip.SetToolTip(this.button1, "Click this button after you\'ve given this application permission to access your F" +
                    "lickr account.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(21, 5);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(114, 23);
            this.saveConfig.TabIndex = 9;
            this.saveConfig.Text = "Save Config";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // cancelConfig
            // 
            this.cancelConfig.Location = new System.Drawing.Point(165, 5);
            this.cancelConfig.Name = "cancelConfig";
            this.cancelConfig.Size = new System.Drawing.Size(126, 23);
            this.cancelConfig.TabIndex = 10;
            this.cancelConfig.Text = "Cancel";
            this.cancelConfig.UseVisualStyleBackColor = true;
            this.cancelConfig.Click += new System.EventHandler(this.cancelConfig_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveConfig);
            this.panel1.Controls.Add(this.cancelConfig);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 32);
            this.panel1.TabIndex = 16;
            // 
            // TabPrefs
            // 
            this.TabPrefs.Controls.Add(this.General);
            this.TabPrefs.Controls.Add(this.FTPOptions);
            this.TabPrefs.Controls.Add(this.FlickrPrefs);
            this.TabPrefs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPrefs.Location = new System.Drawing.Point(0, 0);
            this.TabPrefs.Name = "TabPrefs";
            this.TabPrefs.SelectedIndex = 0;
            this.TabPrefs.Size = new System.Drawing.Size(313, 153);
            this.TabPrefs.TabIndex = 17;
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.Color.White;
            this.General.Controls.Add(this.selectImageFormat);
            this.General.Controls.Add(this.showBalloonTips);
            this.General.Controls.Add(this.ssStorageDir);
            this.General.Controls.Add(this.ssStorageDirBrowse);
            this.General.Controls.Add(this.ssstoragedirlabel);
            this.General.Controls.Add(this.label1);
            this.General.Location = new System.Drawing.Point(4, 22);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(3);
            this.General.Size = new System.Drawing.Size(305, 127);
            this.General.TabIndex = 0;
            this.General.Text = "General";
            // 
            // ssStorageDirBrowse
            // 
            this.ssStorageDirBrowse.Location = new System.Drawing.Point(271, 20);
            this.ssStorageDirBrowse.Name = "ssStorageDirBrowse";
            this.ssStorageDirBrowse.Size = new System.Drawing.Size(26, 23);
            this.ssStorageDirBrowse.TabIndex = 2;
            this.ssStorageDirBrowse.Text = "...";
            this.ssStorageDirBrowse.UseVisualStyleBackColor = true;
            // 
            // ssstoragedirlabel
            // 
            this.ssstoragedirlabel.AutoSize = true;
            this.ssstoragedirlabel.Location = new System.Drawing.Point(56, 3);
            this.ssstoragedirlabel.Name = "ssstoragedirlabel";
            this.ssstoragedirlabel.Size = new System.Drawing.Size(146, 13);
            this.ssstoragedirlabel.TabIndex = 3;
            this.ssstoragedirlabel.Text = "Screenshot Storage Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Image Format";
            // 
            // FTPOptions
            // 
            this.FTPOptions.BackColor = System.Drawing.Color.White;
            this.FTPOptions.Controls.Add(this.ssUpload);
            this.FTPOptions.Controls.Add(this.ftpPassword);
            this.FTPOptions.Controls.Add(this.label3);
            this.FTPOptions.Controls.Add(this.label2);
            this.FTPOptions.Controls.Add(this.label4);
            this.FTPOptions.Controls.Add(this.ftpUsername);
            this.FTPOptions.Controls.Add(this.ftpServer);
            this.FTPOptions.Location = new System.Drawing.Point(4, 22);
            this.FTPOptions.Name = "FTPOptions";
            this.FTPOptions.Padding = new System.Windows.Forms.Padding(3);
            this.FTPOptions.Size = new System.Drawing.Size(305, 127);
            this.FTPOptions.TabIndex = 1;
            this.FTPOptions.Text = "FTP";
            // 
            // ssUpload
            // 
            this.ssUpload.AutoSize = true;
            this.ssUpload.Location = new System.Drawing.Point(6, 6);
            this.ssUpload.Name = "ssUpload";
            this.ssUpload.Size = new System.Drawing.Size(160, 17);
            this.ssUpload.TabIndex = 5;
            this.ssUpload.Text = "Upload screenshots via FTP";
            this.ssUpload.UseVisualStyleBackColor = true;
            // 
            // ftpPassword
            // 
            this.ftpPassword.Location = new System.Drawing.Point(67, 81);
            this.ftpPassword.Name = "ftpPassword";
            this.ftpPassword.PasswordChar = '●';
            this.ftpPassword.Size = new System.Drawing.Size(187, 20);
            this.ftpPassword.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "FTP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password:";
            // 
            // ftpUsername
            // 
            this.ftpUsername.Location = new System.Drawing.Point(67, 55);
            this.ftpUsername.Name = "ftpUsername";
            this.ftpUsername.Size = new System.Drawing.Size(187, 20);
            this.ftpUsername.TabIndex = 7;
            // 
            // ftpServer
            // 
            this.ftpServer.Location = new System.Drawing.Point(67, 29);
            this.ftpServer.Name = "ftpServer";
            this.ftpServer.Size = new System.Drawing.Size(220, 20);
            this.ftpServer.TabIndex = 6;
            // 
            // FlickrPrefs
            // 
            this.FlickrPrefs.Controls.Add(this.successMessage);
            this.FlickrPrefs.Controls.Add(this.ErrorLabel);
            this.FlickrPrefs.Controls.Add(this.button1);
            this.FlickrPrefs.Controls.Add(this.flickrauthtoken);
            this.FlickrPrefs.Controls.Add(this.flickruser);
            this.FlickrPrefs.Controls.Add(this.flickrUpload);
            this.FlickrPrefs.Controls.Add(this.openAuth);
            this.FlickrPrefs.Location = new System.Drawing.Point(4, 22);
            this.FlickrPrefs.Name = "FlickrPrefs";
            this.FlickrPrefs.Padding = new System.Windows.Forms.Padding(3);
            this.FlickrPrefs.Size = new System.Drawing.Size(305, 127);
            this.FlickrPrefs.TabIndex = 2;
            this.FlickrPrefs.Text = "Flickr";
            this.FlickrPrefs.UseVisualStyleBackColor = true;
            // 
            // successMessage
            // 
            this.successMessage.AutoSize = true;
            this.successMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successMessage.ForeColor = System.Drawing.Color.Green;
            this.successMessage.Location = new System.Drawing.Point(8, 101);
            this.successMessage.Name = "successMessage";
            this.successMessage.Size = new System.Drawing.Size(0, 13);
            this.successMessage.TabIndex = 6;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(5, 101);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 5;
            // 
            // flickrauthtoken
            // 
            this.flickrauthtoken.AutoSize = true;
            this.flickrauthtoken.Location = new System.Drawing.Point(9, 81);
            this.flickrauthtoken.Name = "flickrauthtoken";
            this.flickrauthtoken.Size = new System.Drawing.Size(66, 13);
            this.flickrauthtoken.TabIndex = 3;
            this.flickrauthtoken.Text = "Auth Token:";
            // 
            // flickruser
            // 
            this.flickruser.AutoSize = true;
            this.flickruser.Location = new System.Drawing.Point(9, 64);
            this.flickruser.Name = "flickruser";
            this.flickruser.Size = new System.Drawing.Size(58, 13);
            this.flickruser.TabIndex = 2;
            this.flickruser.Text = "Username:";
            // 
            // flickrUpload
            // 
            this.flickrUpload.AutoSize = true;
            this.flickrUpload.Location = new System.Drawing.Point(6, 6);
            this.flickrUpload.Name = "flickrUpload";
            this.flickrUpload.Size = new System.Drawing.Size(170, 17);
            this.flickrUpload.TabIndex = 1;
            this.flickrUpload.Text = "Upload screenshots with Flickr";
            this.flickrUpload.UseVisualStyleBackColor = true;
            // 
            // openAuth
            // 
            this.openAuth.Location = new System.Drawing.Point(9, 34);
            this.openAuth.Name = "openAuth";
            this.openAuth.Size = new System.Drawing.Size(134, 23);
            this.openAuth.TabIndex = 0;
            this.openAuth.Text = "Open Auth URL";
            this.openAuth.UseVisualStyleBackColor = true;
            this.openAuth.Click += new System.EventHandler(this.openAuth_Click);
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 185);
            this.Controls.Add(this.TabPrefs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.panel1.ResumeLayout(false);
            this.TabPrefs.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.FTPOptions.ResumeLayout(false);
            this.FTPOptions.PerformLayout();
            this.FlickrPrefs.ResumeLayout(false);
            this.FlickrPrefs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tTip;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.Button cancelConfig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabPrefs;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.ComboBox selectImageFormat;
        private System.Windows.Forms.CheckBox showBalloonTips;
        private System.Windows.Forms.TextBox ssStorageDir;
        private System.Windows.Forms.Button ssStorageDirBrowse;
        private System.Windows.Forms.Label ssstoragedirlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage FTPOptions;
        private System.Windows.Forms.CheckBox ssUpload;
        private System.Windows.Forms.TextBox ftpPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ftpUsername;
        private System.Windows.Forms.TextBox ftpServer;
        private System.Windows.Forms.TabPage FlickrPrefs;
        private System.Windows.Forms.Button openAuth;
        private System.Windows.Forms.CheckBox flickrUpload;
        private System.Windows.Forms.Label flickrauthtoken;
        private System.Windows.Forms.Label flickruser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label successMessage;
    }
}