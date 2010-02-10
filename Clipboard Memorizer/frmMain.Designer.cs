namespace ClipboardManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.nIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHotkey = new System.Windows.Forms.Timer(this.components);
            this.sessionStart = new System.Windows.Forms.Label();
            this.archiveFileName = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noscrnshots = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearUploadQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.queueStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clipboardData0 = new System.Windows.Forms.TextBox();
            this.clipboardData1 = new System.Windows.Forms.TextBox();
            this.clipboardData2 = new System.Windows.Forms.TextBox();
            this.clipboardData3 = new System.Windows.Forms.TextBox();
            this.clipboardData4 = new System.Windows.Forms.TextBox();
            this.copy0 = new System.Windows.Forms.Button();
            this.copy1 = new System.Windows.Forms.Button();
            this.copy2 = new System.Windows.Forms.Button();
            this.copy3 = new System.Windows.Forms.Button();
            this.copy4 = new System.Windows.Forms.Button();
            this.ssInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nIcon1
            // 
            this.nIcon1.ContextMenuStrip = this.cMnu;
            this.nIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon1.Icon")));
            this.nIcon1.Text = "Clipboard Manager";
            this.nIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nIcon1_MouseDoubleClick);
            // 
            // cMnu
            // 
            this.cMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.cMnu.Name = "cMnu";
            this.cMnu.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tHotkey
            // 
            this.tHotkey.Interval = 1;
            this.tHotkey.Tick += new System.EventHandler(this.tHotkey_Tick);
            // 
            // sessionStart
            // 
            this.sessionStart.AutoSize = true;
            this.sessionStart.Location = new System.Drawing.Point(13, 30);
            this.sessionStart.Name = "sessionStart";
            this.sessionStart.Size = new System.Drawing.Size(84, 13);
            this.sessionStart.TabIndex = 0;
            this.sessionStart.Text = "Session Started:";
            // 
            // archiveFileName
            // 
            this.archiveFileName.AutoSize = true;
            this.archiveFileName.Location = new System.Drawing.Point(13, 47);
            this.archiveFileName.Name = "archiveFileName";
            this.archiveFileName.Size = new System.Drawing.Size(65, 13);
            this.archiveFileName.TabIndex = 1;
            this.archiveFileName.Text = "Archive File:";
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(6, 13);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(338, 153);
            this.ss.TabIndex = 5;
            this.ss.TabStop = false;
            this.ss.Click += new System.EventHandler(this.ss_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noscrnshots);
            this.groupBox1.Controls.Add(this.ss);
            this.groupBox1.Location = new System.Drawing.Point(16, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Screenshot Preview - Click to Open";
            // 
            // noscrnshots
            // 
            this.noscrnshots.AutoSize = true;
            this.noscrnshots.Location = new System.Drawing.Point(132, 80);
            this.noscrnshots.Name = "noscrnshots";
            this.noscrnshots.Size = new System.Drawing.Size(83, 13);
            this.noscrnshots.TabIndex = 6;
            this.noscrnshots.Text = "No Screenshots";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.uploadToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.newSessionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("preferencesToolStripMenuItem.Image")));
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newSessionToolStripMenuItem.Image")));
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newSessionToolStripMenuItem.Text = "&New Session";
            this.newSessionToolStripMenuItem.Click += new System.EventHandler(this.newSessionToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearUploadQueueToolStripMenuItem});
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.uploadToolStripMenuItem.Text = "&Upload";
            // 
            // clearUploadQueueToolStripMenuItem
            // 
            this.clearUploadQueueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearUploadQueueToolStripMenuItem.Image")));
            this.clearUploadQueueToolStripMenuItem.Name = "clearUploadQueueToolStripMenuItem";
            this.clearUploadQueueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearUploadQueueToolStripMenuItem.Text = "&Clear Upload Queue";
            this.clearUploadQueueToolStripMenuItem.Click += new System.EventHandler(this.clearUploadQueueToolStripMenuItem_Click);
            // 
            // uploadWorker
            // 
            this.uploadWorker.WorkerReportsProgress = true;
            this.uploadWorker.WorkerSupportsCancellation = true;
            this.uploadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.uploadWorker_DoWork);
            this.uploadWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.uploadWorker_ProgressChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.tsStatus,
            this.queueStatusLabel,
            this.speedLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(375, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // queueStatusLabel
            // 
            this.queueStatusLabel.Name = "queueStatusLabel";
            this.queueStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedLabel
            // 
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // clipboardData0
            // 
            this.clipboardData0.Location = new System.Drawing.Point(16, 72);
            this.clipboardData0.Multiline = true;
            this.clipboardData0.Name = "clipboardData0";
            this.clipboardData0.Size = new System.Drawing.Size(272, 20);
            this.clipboardData0.TabIndex = 10;
            // 
            // clipboardData1
            // 
            this.clipboardData1.Location = new System.Drawing.Point(16, 98);
            this.clipboardData1.Multiline = true;
            this.clipboardData1.Name = "clipboardData1";
            this.clipboardData1.Size = new System.Drawing.Size(272, 20);
            this.clipboardData1.TabIndex = 11;
            // 
            // clipboardData2
            // 
            this.clipboardData2.Location = new System.Drawing.Point(16, 124);
            this.clipboardData2.Multiline = true;
            this.clipboardData2.Name = "clipboardData2";
            this.clipboardData2.Size = new System.Drawing.Size(272, 20);
            this.clipboardData2.TabIndex = 12;
            // 
            // clipboardData3
            // 
            this.clipboardData3.Location = new System.Drawing.Point(16, 150);
            this.clipboardData3.Multiline = true;
            this.clipboardData3.Name = "clipboardData3";
            this.clipboardData3.Size = new System.Drawing.Size(272, 20);
            this.clipboardData3.TabIndex = 13;
            // 
            // clipboardData4
            // 
            this.clipboardData4.Location = new System.Drawing.Point(16, 176);
            this.clipboardData4.Multiline = true;
            this.clipboardData4.Name = "clipboardData4";
            this.clipboardData4.Size = new System.Drawing.Size(272, 20);
            this.clipboardData4.TabIndex = 14;
            // 
            // copy0
            // 
            this.copy0.Location = new System.Drawing.Point(294, 70);
            this.copy0.Name = "copy0";
            this.copy0.Size = new System.Drawing.Size(75, 23);
            this.copy0.TabIndex = 15;
            this.copy0.Text = "Copy";
            this.copy0.UseVisualStyleBackColor = true;
            this.copy0.Click += new System.EventHandler(this.copy0_Click);
            // 
            // copy1
            // 
            this.copy1.Location = new System.Drawing.Point(294, 97);
            this.copy1.Name = "copy1";
            this.copy1.Size = new System.Drawing.Size(75, 23);
            this.copy1.TabIndex = 17;
            this.copy1.Text = "Copy";
            this.copy1.UseVisualStyleBackColor = true;
            this.copy1.Click += new System.EventHandler(this.copy1_Click);
            // 
            // copy2
            // 
            this.copy2.Location = new System.Drawing.Point(294, 123);
            this.copy2.Name = "copy2";
            this.copy2.Size = new System.Drawing.Size(75, 23);
            this.copy2.TabIndex = 19;
            this.copy2.Text = "Copy";
            this.copy2.UseVisualStyleBackColor = true;
            this.copy2.Click += new System.EventHandler(this.copy2_Click);
            // 
            // copy3
            // 
            this.copy3.Location = new System.Drawing.Point(294, 148);
            this.copy3.Name = "copy3";
            this.copy3.Size = new System.Drawing.Size(75, 23);
            this.copy3.TabIndex = 21;
            this.copy3.Text = "Copy";
            this.copy3.UseVisualStyleBackColor = true;
            this.copy3.Click += new System.EventHandler(this.copy3_Click);
            // 
            // copy4
            // 
            this.copy4.Location = new System.Drawing.Point(294, 174);
            this.copy4.Name = "copy4";
            this.copy4.Size = new System.Drawing.Size(75, 23);
            this.copy4.TabIndex = 23;
            this.copy4.Text = "Copy";
            this.copy4.UseVisualStyleBackColor = true;
            this.copy4.Click += new System.EventHandler(this.copy4_Click);
            // 
            // ssInfo
            // 
            this.ssInfo.AutoSize = true;
            this.ssInfo.Location = new System.Drawing.Point(13, 394);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(0, 13);
            this.ssInfo.TabIndex = 25;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 20;
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 20;
            this.toolTip1.ReshowDelay = 4;
            this.toolTip1.ShowAlways = true;
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screenInfoToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // screenInfoToolStripMenuItem
            // 
            this.screenInfoToolStripMenuItem.Name = "screenInfoToolStripMenuItem";
            this.screenInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.screenInfoToolStripMenuItem.Text = "Screen Info";
            this.screenInfoToolStripMenuItem.Click += new System.EventHandler(this.screenInfoToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 436);
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.copy3);
            this.Controls.Add(this.copy4);
            this.Controls.Add(this.clipboardData4);
            this.Controls.Add(this.copy2);
            this.Controls.Add(this.copy1);
            this.Controls.Add(this.copy0);
            this.Controls.Add(this.clipboardData3);
            this.Controls.Add(this.clipboardData2);
            this.Controls.Add(this.clipboardData1);
            this.Controls.Add(this.clipboardData0);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.archiveFileName);
            this.Controls.Add(this.sessionStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Clipboard Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.cMnu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ss)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nIcon1;
        private System.Windows.Forms.Timer tHotkey;
        private System.Windows.Forms.Label sessionStart;
        private System.Windows.Forms.Label archiveFileName;
        private System.Windows.Forms.ContextMenuStrip cMnu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox ss;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker uploadWorker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel queueStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel speedLabel;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearUploadQueueToolStripMenuItem;
        private System.Windows.Forms.TextBox clipboardData0;
        private System.Windows.Forms.TextBox clipboardData1;
        private System.Windows.Forms.TextBox clipboardData2;
        private System.Windows.Forms.TextBox clipboardData3;
        private System.Windows.Forms.TextBox clipboardData4;
        private System.Windows.Forms.Button copy0;
        private System.Windows.Forms.Button copy1;
        private System.Windows.Forms.Button copy2;
        private System.Windows.Forms.Button copy3;
        private System.Windows.Forms.Button copy4;
        private System.Windows.Forms.Label noscrnshots;
        private System.Windows.Forms.Label ssInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenInfoToolStripMenuItem;
    }
}

