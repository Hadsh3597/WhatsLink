namespace WhatsLink_Alpha
{
    partial class UC_1
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblLinkGerado = new LinkLabel();
            miniToolStrip = new MenuStrip();
            linkLabel1 = new LinkLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnMsg4 = new Button();
            btnMsg3 = new Button();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnMsg2 = new Button();
            btnMsg1 = new Button();
            txtTelefone = new MaskedTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblLinkGerado
            // 
            lblLinkGerado.AutoSize = true;
            lblLinkGerado.Location = new Point(9, 150);
            lblLinkGerado.Margin = new Padding(4, 0, 4, 0);
            lblLinkGerado.Name = "lblLinkGerado";
            lblLinkGerado.Size = new Size(0, 15);
            lblLinkGerado.TabIndex = 9;
            lblLinkGerado.Visible = false;
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "Nova seleção de item";
            miniToolStrip.AccessibleRole = AccessibleRole.ComboBox;
            miniToolStrip.AutoSize = false;
            miniToolStrip.BackColor = Color.White;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.Location = new Point(56, 1);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(424, 21);
            miniToolStrip.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.Control;
            linkLabel1.Location = new Point(9, 150);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(txtTelefone, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(424, 301);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnMsg4, 1, 0);
            tableLayoutPanel3.Controls.Add(btnMsg3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 207);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(418, 69);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // btnMsg4
            // 
            btnMsg4.Anchor = AnchorStyles.None;
            btnMsg4.Cursor = Cursors.Hand;
            btnMsg4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMsg4.Location = new Point(241, 19);
            btnMsg4.Margin = new Padding(4, 3, 4, 3);
            btnMsg4.Name = "btnMsg4";
            btnMsg4.Size = new Size(144, 31);
            btnMsg4.TabIndex = 8;
            btnMsg4.Text = "sem mensagem salva";
            btnMsg4.UseVisualStyleBackColor = true;
            btnMsg4.Click += btnMsg4_Click;
            // 
            // btnMsg3
            // 
            btnMsg3.Anchor = AnchorStyles.None;
            btnMsg3.Cursor = Cursors.Hand;
            btnMsg3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMsg3.Location = new Point(32, 19);
            btnMsg3.Margin = new Padding(4, 3, 4, 3);
            btnMsg3.Name = "btnMsg3";
            btnMsg3.Size = new Size(144, 31);
            btnMsg3.TabIndex = 7;
            btnMsg3.Text = "sem mensagem salva";
            btnMsg3.UseVisualStyleBackColor = true;
            btnMsg3.Click += btnMsg3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 15);
            label1.Name = "label1";
            label1.Size = new Size(170, 24);
            label1.TabIndex = 1;
            label1.Text = "Insira o número";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnMsg2, 1, 0);
            tableLayoutPanel2.Controls.Add(btnMsg1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 132);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(418, 69);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnMsg2
            // 
            btnMsg2.Anchor = AnchorStyles.None;
            btnMsg2.Cursor = Cursors.Hand;
            btnMsg2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMsg2.Location = new Point(241, 19);
            btnMsg2.Margin = new Padding(4, 3, 4, 3);
            btnMsg2.Name = "btnMsg2";
            btnMsg2.Size = new Size(144, 31);
            btnMsg2.TabIndex = 5;
            btnMsg2.Text = "sem mensagem salva";
            btnMsg2.UseVisualStyleBackColor = true;
            btnMsg2.Click += btnMsg2_Click;
            // 
            // btnMsg1
            // 
            btnMsg1.Anchor = AnchorStyles.None;
            btnMsg1.Cursor = Cursors.Hand;
            btnMsg1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMsg1.Location = new Point(32, 19);
            btnMsg1.Margin = new Padding(4, 3, 4, 3);
            btnMsg1.Name = "btnMsg1";
            btnMsg1.Size = new Size(144, 31);
            btnMsg1.TabIndex = 4;
            btnMsg1.Text = "sem mensagem salva";
            btnMsg1.UseVisualStyleBackColor = true;
            btnMsg1.Click += btnMsg1_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.None;
            txtTelefone.Location = new Point(162, 80);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 7;
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // UC_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(linkLabel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblLinkGerado);
            Name = "UC_1";
            Size = new Size(424, 301);
            Load += UC_1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lblLinkGerado;
        private MenuStrip miniToolStrip;
        private LinkLabel linkLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button btnMsg1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnMsg4;
        private Button btnMsg3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnMsg2;
        private MaskedTextBox txtTelefone;
    }
}
