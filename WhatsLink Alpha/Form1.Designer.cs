namespace WhatsLink_Alpha
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            msgProgramadasToolStripMenuItem = new ToolStripMenuItem();
            msgTempoToolStripMenuItem = new ToolStripMenuItem();
            ajustesToolStripMenuItem = new ToolStripMenuItem();
            ajustesMsgTempoToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            resetarConfiguraçõesToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            uC_21 = new UC_2();
            uC_home1 = new UC_home();
            uC_Config1 = new UC_Config();
            uC_11 = new UC_1();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.GripMargin = new Padding(0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, msgProgramadasToolStripMenuItem, msgTempoToolStripMenuItem, ajustesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(408, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(48, 20);
            menuToolStripMenuItem.Text = "Inicio";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // msgProgramadasToolStripMenuItem
            // 
            msgProgramadasToolStripMenuItem.Name = "msgProgramadasToolStripMenuItem";
            msgProgramadasToolStripMenuItem.Size = new Size(115, 20);
            msgProgramadasToolStripMenuItem.Text = "msg programadas";
            msgProgramadasToolStripMenuItem.Click += msgProgramadasToolStripMenuItem_Click;
            // 
            // msgTempoToolStripMenuItem
            // 
            msgTempoToolStripMenuItem.Name = "msgTempoToolStripMenuItem";
            msgTempoToolStripMenuItem.Size = new Size(80, 20);
            msgTempoToolStripMenuItem.Text = "msg tempo";
            msgTempoToolStripMenuItem.Click += msgTempoToolStripMenuItem_Click;
            // 
            // ajustesToolStripMenuItem
            // 
            ajustesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajustesMsgTempoToolStripMenuItem, resetToolStripMenuItem });
            ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            ajustesToolStripMenuItem.Size = new Size(55, 20);
            ajustesToolStripMenuItem.Text = "ajustes";
            ajustesToolStripMenuItem.Click += ajustesToolStripMenuItem_Click;
            // 
            // ajustesMsgTempoToolStripMenuItem
            // 
            ajustesMsgTempoToolStripMenuItem.Name = "ajustesMsgTempoToolStripMenuItem";
            ajustesMsgTempoToolStripMenuItem.Size = new Size(174, 22);
            ajustesMsgTempoToolStripMenuItem.Text = "ajustes msg tempo";
            ajustesMsgTempoToolStripMenuItem.Click += ajustesMsgTempoToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetarConfiguraçõesToolStripMenuItem });
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(174, 22);
            resetToolStripMenuItem.Text = "reset";
            // 
            // resetarConfiguraçõesToolStripMenuItem
            // 
            resetarConfiguraçõesToolStripMenuItem.Name = "resetarConfiguraçõesToolStripMenuItem";
            resetarConfiguraçõesToolStripMenuItem.Size = new Size(190, 22);
            resetarConfiguraçõesToolStripMenuItem.Text = "Resetar configurações";
            resetarConfiguraçõesToolStripMenuItem.Click += resetarConfiguraçõesToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(uC_21);
            panel1.Controls.Add(uC_home1);
            panel1.Controls.Add(uC_Config1);
            panel1.Controls.Add(uC_11);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 238);
            panel1.TabIndex = 2;
            // 
            // uC_21
            // 
            uC_21.Location = new Point(209, 0);
            uC_21.Name = "uC_21";
            uC_21.Size = new Size(96, 92);
            uC_21.TabIndex = 3;
            // 
            // uC_home1
            // 
            uC_home1.Location = new Point(119, 0);
            uC_home1.Name = "uC_home1";
            uC_home1.Size = new Size(84, 238);
            uC_home1.TabIndex = 2;
            // 
            // uC_Config1
            // 
            uC_Config1.Location = new Point(0, 0);
            uC_Config1.Name = "uC_Config1";
            uC_Config1.Size = new Size(113, 235);
            uC_Config1.TabIndex = 1;
            // 
            // uC_11
            // 
            uC_11.BackColor = SystemColors.ControlDarkDark;
            uC_11.Location = new Point(311, 0);
            uC_11.Name = "uC_11";
            uC_11.Size = new Size(97, 238);
            uC_11.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 240);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(408, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(40, 17);
            toolStripStatusLabel1.Text = "ByGris";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 262);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimumSize = new Size(250, 150);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WhatsLink";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem msgProgramadasToolStripMenuItem;
        private UC_home uC_home1;
        private UC_Config uC_Config1;
        private UC_1 uC_11;
        private ToolStripMenuItem msgTempoToolStripMenuItem;
        private ToolStripMenuItem ajustesToolStripMenuItem;
        private ToolStripMenuItem ajustesMsgTempoToolStripMenuItem;
        private UC_2 uC_21;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem resetarConfiguraçõesToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}