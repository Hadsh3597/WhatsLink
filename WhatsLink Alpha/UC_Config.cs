using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WhatsLink_Alpha
{
    public partial class UC_Config : UserControl
    {
        public UC_Config()
        {
            InitializeComponent();
        }
        private void UC_config_Load(object sender, EventArgs e)
        {
            txtMsg1.Text = Properties.Settings.Default.Mensagem1;
            txtMsg2.Text = Properties.Settings.Default.Mensagem2;
            txtMsg3.Text = Properties.Settings.Default.Mensagem3;
            txtMsg4.Text = Properties.Settings.Default.Mensagem4;

            txtPrevia1.Text = Properties.Settings.Default.btn1;
            txtPrevia2.Text = Properties.Settings.Default.btn2;
            txtPrevia3.Text = Properties.Settings.Default.btn3;
            txtPrevia4.Text = Properties.Settings.Default.btn4;

            EnterCheck.Checked = Properties.Settings.Default.EnviarAuto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Mensagem1 = txtMsg1.Text;
            Properties.Settings.Default.Mensagem2 = txtMsg2.Text;
            Properties.Settings.Default.Mensagem3 = txtMsg3.Text;
            Properties.Settings.Default.Mensagem4 = txtMsg4.Text;

            Properties.Settings.Default.btn1 = txtPrevia1.Text;
            Properties.Settings.Default.btn2 = txtPrevia2.Text;
            Properties.Settings.Default.btn3 = txtPrevia3.Text;
            Properties.Settings.Default.btn4 = txtPrevia4.Text;

            Properties.Settings.Default.EnviarAuto = EnterCheck.Checked;

            Properties.Settings.Default.Save();

            var formPrincipal = this.ParentForm as Form1;
            if (formPrincipal != null)
            {
                formPrincipal.AtualizarMensagemStatus("✅ Configurações salvas!", Color.DarkGreen);
            }

        }
    }
}
