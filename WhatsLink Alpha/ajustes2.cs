using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WhatsLink_Alpha
{
    public partial class ajustes2 : UserControl
    {
        public ajustes2()
        {
            InitializeComponent();
        }

        private void UC_ajustes_Load(object sender, EventArgs e)
        {
            txtTempoA.Text = Properties.Settings.Default.txtTempo1;
            txtTempoB.Text = Properties.Settings.Default.txtTempo2;
            ExampleLabel.Text = Properties.Settings.Default.txtTempo1 + " 15 " + Properties.Settings.Default.txtTempo2;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.txtTempo1 = txtTempoA.Text;
            Properties.Settings.Default.txtTempo2 = txtTempoB.Text;

            Properties.Settings.Default.Save();

            UC_ajustes_Load(sender, e);

            MessageBox.Show("Todas as configurações foram salvas com sucesso!");
        }


    }
}
