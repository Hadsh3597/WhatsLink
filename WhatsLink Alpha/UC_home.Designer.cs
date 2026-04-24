namespace WhatsLink_Alpha
{
    partial class UC_home
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
            label1 = new Label();
            btnGerarLink = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTelefone = new MaskedTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // btnGerarLink
            // 
            btnGerarLink.Anchor = AnchorStyles.None;
            btnGerarLink.Cursor = Cursors.Hand;
            btnGerarLink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerarLink.Location = new Point(140, 148);
            btnGerarLink.Margin = new Padding(4, 3, 4, 3);
            btnGerarLink.Name = "btnGerarLink";
            btnGerarLink.Size = new Size(144, 31);
            btnGerarLink.TabIndex = 3;
            btnGerarLink.Text = "Enviar mensagem";
            btnGerarLink.UseVisualStyleBackColor = true;
            btnGerarLink.Click += btnGerarLink_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnGerarLink, 0, 2);
            tableLayoutPanel1.Controls.Add(txtTelefone, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(424, 301);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.None;
            txtTelefone.Location = new Point(162, 79);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 8;
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            txtTelefone.KeyDown += txtTelefone_KeyDown;
            // 
            // UC_home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_home";
            Size = new Size(424, 301);
            Load += UC_home_Load;
            Enter += UC_1_VisibleChanged;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btnGerarLink;
        private TableLayoutPanel tableLayoutPanel1;
        private MaskedTextBox txtTelefone;
    }
}
