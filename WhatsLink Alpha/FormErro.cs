using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace WhatsLink_Alpha
{
    public partial class FormErro : Form
    {
        public FormErro()
        {
            InitializeComponent();
        }

        private void FormError_Load(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
        }

        private void BTNok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
