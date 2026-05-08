using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WhatsLink_Alpha
{
    public partial class Whatopen : Form
    {
        public Whatopen()
        {
            InitializeComponent();

        }

        private void NewDesign_Load(object sender, EventArgs e)
        {
            panel2.Controls.Add(new UC_home() { Dock = DockStyle.Fill });
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(238, 244, 249);
        }


        private void Form1_Deactivate(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new UC_1() { Dock = DockStyle.Fill });
            this.Size = new Size(449, 318);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new UC_2() { Dock = DockStyle.Fill });
            this.Size = new Size(449, 318);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new UC_Config() { Dock = DockStyle.Fill });
            this.Size = new Size(709, 600);
            this.CentralizarNoMonitor();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new UC_home() { Dock = DockStyle.Fill });
            this.Size = new Size(449, 318);
        }

        public void CentralizarNoMonitor()
        {
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
        }


    }


}
