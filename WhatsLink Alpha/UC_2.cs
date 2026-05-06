using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace WhatsLink_Alpha
{
    public partial class UC_2 : UserControl
    {
        public UC_2()
        {
            InitializeComponent();
        }

        private void btnGerarLink_Click(object sender, EventArgs e)
        {
            AbrirMensagemSoNumero();
        }

        public void AbrirMensagemSoNumero()
        {
            if (!string.IsNullOrWhiteSpace(NumMin.Text) && NumMin.Text.All(char.IsDigit))
            {
                AbrirNoAppComMensagem(Properties.Settings.Default.txtTempo1 + " " + NumMin.Text + " " + Properties.Settings.Default.txtTempo2);
                txtTelefone.Focus();
            }
            else
            {
                using (FormErro aviso = new FormErro())
                {
                    aviso.ShowDialog();
                }
                txtTelefone.Focus();
                //MessageBox.Show("digite apenas numeros");
            }
        }
        public void AbrirNoAppComMensagem(string mensagem)
        {
            string texto = txtTelefone.Text;
            string apenasNumeros = new string(texto.Where(char.IsDigit).ToArray());

            if (apenasNumeros.Length >= 10)
            {
                if (!apenasNumeros.StartsWith("55"))
                    apenasNumeros = "55" + apenasNumeros;

                string mensagemFormatada = Uri.EscapeDataString(mensagem);
                string urlApp = $"whatsapp://send?phone={apenasNumeros}&text={mensagemFormatada}";

                try
                {
                    Process.Start(new ProcessStartInfo(urlApp) { UseShellExecute = true });

                    txtTelefone.Clear();
                    txtTelefone.Focus();

                    if (Properties.Settings.Default.EnviarAuto)
                    {
                        Thread.Sleep(1000);
                        SendKeys.SendWait("{ENTER}");
                    }
                }
                catch (Exception)
                {
                    string urlWeb = $"https://wa.me/{apenasNumeros}?text={mensagemFormatada}";
                    Process.Start(new ProcessStartInfo(urlWeb) { UseShellExecute = true });
                }
            }
            else
            {
                using (FormErro aviso = new FormErro())
                {
                    aviso.ShowDialog();
                }
                txtTelefone.Focus();
                //MessageBox.Show("Digite o número com DDD primeiro.");
            }
        }

        public void OnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NumMin.Focus();
            }
        }

        private void UC_2_Load(object sender, EventArgs e)
        {
            txtTelefone.Focus();
        }

        private void OnEnterEnviar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AbrirMensagemSoNumero();
                txtTelefone.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
