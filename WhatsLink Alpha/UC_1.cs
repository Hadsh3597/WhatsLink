using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace WhatsLink_Alpha
{
    public partial class UC_1 : UserControl
    {
        public UC_1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PerguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

                    lblLinkGerado.Text = $"wa.me/{apenasNumeros}";

                    txtTelefone.Clear();
                    txtTelefone.Focus();
                    Thread.Sleep(1000);
                    SendKeys.SendWait("{ENTER}");
                }
                catch (Exception)
                {
                    string urlWeb = $"https://wa.me/{apenasNumeros}?text={mensagemFormatada}";
                    Process.Start(new ProcessStartInfo(urlWeb) { UseShellExecute = true });
                }
            }
            else
            {
                MessageBox.Show("Digite o número com DDD primeiro.");
            }
        }

        public void AtualizarBotoes()
        {
            string n1 = global::WhatsLink_Alpha.Properties.Settings.Default.btn1;
            string n2 = global::WhatsLink_Alpha.Properties.Settings.Default.btn2;
            string n3 = global::WhatsLink_Alpha.Properties.Settings.Default.btn3;
            string n4 = global::WhatsLink_Alpha.Properties.Settings.Default.btn4;

            btnMsg1.Text = string.IsNullOrWhiteSpace(n1) ? "sem mensagem salva" : n1;
            btnMsg2.Text = string.IsNullOrWhiteSpace(n2) ? "sem mensagem salva" : n2;
            btnMsg3.Text = string.IsNullOrWhiteSpace(n3) ? "sem mensagem salva" : n3;
            btnMsg4.Text = string.IsNullOrWhiteSpace(n4) ? "sem mensagem salva" : n4;


            if (string.IsNullOrWhiteSpace(btnMsg1.Text)) btnMsg1.Text = "Mensagem 1";
        }

        private void UC_1_Load(object sender, EventArgs e)
        {
            AtualizarBotoes();
            txtTelefone.Focus();
        }

        private void btnMsg1_Click(object sender, EventArgs e)
        {
            AbrirNoAppComMensagem(Properties.Settings.Default.Mensagem1);
        }

        private void btnMsg2_Click(object sender, EventArgs e)
        {
            AbrirNoAppComMensagem(Properties.Settings.Default.Mensagem2);
        }

        private void btnMsg3_Click(object sender, EventArgs e)
        {
            AbrirNoAppComMensagem(Properties.Settings.Default.Mensagem3);
        }

        private void btnMsg4_Click(object sender, EventArgs e)
        {
            AbrirNoAppComMensagem(Properties.Settings.Default.Mensagem4);
        }
    }
}
