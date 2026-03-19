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
            AbrirNoPainel<UC_home>();
            ConfigurarEstiloMenu();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AbrirNoPainel<T>() where T : UserControl, new()
        {
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();

            T uc = new T();
            uc.Dock = DockStyle.Fill;

            panel1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void ConfigurarEstiloMenu()
        {
            if (this.menuStrip1 != null)
            {
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    if (item.DropDown is ToolStripDropDownMenu menuDropdown)
                    {
                        menuDropdown.ShowCheckMargin = false;
                        menuDropdown.ShowImageMargin = false;
                    }
                }
            }
        }

        private void UC_home_Load(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.DropDown is ToolStripDropDownMenu menuDropdown)
                {
                    menuDropdown.ShowCheckMargin = false;
                    menuDropdown.ShowImageMargin = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ((ToolStripDropDownMenu)menuToolStripMenuItem.DropDown).ShowCheckMargin = false;
            ((ToolStripDropDownMenu)menuToolStripMenuItem.DropDown).ShowImageMargin = false;
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNoPainel<UC_Config>();
            AbrirConfiguracoes();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNoPainel<UC_home>();
            AbrirHome();
        }

        private void msgProgramadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNoPainel<UC_1>();
            this.Size = new Size(424, 301);
        }

        public void AbrirConfiguracoes()
        {
            this.Size = new Size(700, 600);
        }

        public void AbrirHome()
        {
            this.Size = new Size(424, 301);
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNoPainel<UC_Config>();
            AbrirConfiguracoes();

        }

        private void ajustesMsgTempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNoPainel<ajustes2>();
            AbrirConfiguracoes();
        }

        private void msgTempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNoPainel<UC_2>();
            AbrirHome();
        }

        private void resetarConfiguraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
            MessageBox.Show("Memória limpa! Agora salve novamente.");
        }

        public void AtualizarMensagemStatus(string texto, Color cor)
        {
            lblStatus.Text = texto;
            lblStatus.ForeColor = cor;

            timerStatus.Stop();
            timerStatus.Start();
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            timerStatus.Stop();
        
        }
    }
}
