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
    public partial class frmScreenInfo : Form
    {
        public frmScreenInfo()
        {
            InitializeComponent();
        }

        public Screen[] screens;
        frmOverlay overlay;

        private void Form1_Load(object sender, EventArgs e)
        {
            screens = Screen.AllScreens;

            int i = 0;

            foreach (Screen screen in screens)
            {
                Label iterLabel = new Label();
                iterLabel.AutoSize = true;
                iterLabel.Name = "Screen" + i.ToString();
                iterLabel.Location = new Point(0, i*25);
                iterLabel.Text = "Screen " + i.ToString() + " " + screen.Bounds.ToString();
                this.Controls.Add(iterLabel);
                i++;
            }
        }

        public int WhichScreen()
        {
            int i = 0;
            foreach (Screen screen in screens)
            {
                if (screen.Bounds.Contains(Cursor.Position))
                    return i;
                else
                    i++;
            }
            return -1;
        }

        private void mouseTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = "Mouse Coordinates: " + Cursor.Position.ToString() + " On Screen: " + WhichScreen().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          overlay = new frmOverlay();
          overlay.Show();
          overlay.FormClosing += new FormClosingEventHandler(overlay_FormClosing);
        }

        void overlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cutrectlabel.Text = "Saved Image: " + overlay.ssFileName;
        }
    }
}
