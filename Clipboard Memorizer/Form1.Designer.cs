namespace ClipboardManager
{
    partial class frmScreenInfo
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
            this.mouseTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cutrectlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mouseTimer
            // 
            this.mouseTimer.Enabled = true;
            this.mouseTimer.Interval = 10;
            this.mouseTimer.Tick += new System.EventHandler(this.mouseTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse Coordinates:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Test Overlay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cutrectlabel
            // 
            this.cutrectlabel.AutoSize = true;
            this.cutrectlabel.Location = new System.Drawing.Point(12, 91);
            this.cutrectlabel.Name = "cutrectlabel";
            this.cutrectlabel.Size = new System.Drawing.Size(96, 13);
            this.cutrectlabel.TabIndex = 3;
            this.cutrectlabel.Text = "Returned CutRect:";
            // 
            // frmScreenInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 137);
            this.Controls.Add(this.cutrectlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmScreenInfo";
            this.Text = "Screen Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mouseTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cutrectlabel;
    }
}