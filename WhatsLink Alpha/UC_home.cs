using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WhatsLink_Alpha
{
    public partial class UC_home : UserControl
    {
        public UC_home()
        {
            InitializeComponent();
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGerarLink_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }



        private void btnGerarLink_Click(object sender, EventArgs e)
        {
            string texto = txtTelefone.Text;
            string apenasNumeros = new string(texto.Where(char.IsDigit).ToArray());

            if (apenasNumeros.Length >= 10)
            {
                if (!apenasNumeros.StartsWith("55"))
                    apenasNumeros = "55" + apenasNumeros;

                string urlApp = $"whatsapp://send?phone={apenasNumeros}";
                string urlWeb = $"https://wa.me/{apenasNumeros}";

                try
                {
                    Process.Start(new ProcessStartInfo(urlApp) { UseShellExecute = true });
                }
                catch
                {
                    Process.Start(new ProcessStartInfo(urlWeb) { UseShellExecute = true });
                }

                txtTelefone.Clear();
                txtTelefone.Focus();
            }
            else
            {
                MessageBox.Show("Digite o número com DDD.");
            }

        }

        private void PerguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UC_home_Load(object sender, EventArgs e)
        {
            txtTelefone.Focus ();
        }

        private void UC_1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                txtTelefone.BeginInvoke((Action)delegate {
                    txtTelefone.Focus();
                });
            }
        }
    }
}
