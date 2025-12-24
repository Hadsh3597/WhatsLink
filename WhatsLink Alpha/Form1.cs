using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WhatsLink_Alpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                    // Abre o WhatsApp Desktop direto
                    Process.Start(new ProcessStartInfo(urlApp) { UseShellExecute = true });
                }
                catch
                {
                    // Se não tiver o app, abre no navegador
                    Process.Start(new ProcessStartInfo(urlWeb) { UseShellExecute = true });
                }

                lblLinkGerado.Text = urlWeb;

                // Limpa e foca para o próximo uso
                txtTelefone.Clear();
                txtTelefone.Focus();
            }
            else
            {
                MessageBox.Show("Digite o número com DDD.");
            }
        }

        // ESSA É A FUNÇÃO QUE O DESIGNER ESTÁ PEDINDO PARA O ERRO SUMIR
        private void lblLinkGerado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(lblLinkGerado.Text))
            {
                Process.Start(new ProcessStartInfo(lblLinkGerado.Text) { UseShellExecute = true });
            }
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGerarLink_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}