namespace WhatsLink_Alpha
{
    partial class UC_2
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            txtTelefone = new TextBox();
            btnGerarLink = new Button();
            NumMin = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(txtTelefone, 0, 1);
            tableLayoutPanel1.Controls.Add(btnGerarLink, 0, 4);
            tableLayoutPanel1.Controls.Add(NumMin, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(424, 301);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 15);
            label1.Name = "label1";
            label1.Size = new Size(170, 24);
            label1.TabIndex = 0;
            label1.Text = "Insira o número";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 149);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 3;
            label3.Text = "minutos para a entrega";
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.None;
            txtTelefone.Location = new Point(130, 63);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(163, 23);
            txtTelefone.TabIndex = 1;
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGerarLink
            // 
            btnGerarLink.Anchor = AnchorStyles.None;
            btnGerarLink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerarLink.Location = new Point(140, 182);
            btnGerarLink.Margin = new Padding(4, 3, 4, 3);
            btnGerarLink.Name = "btnGerarLink";
            btnGerarLink.Size = new Size(144, 31);
            btnGerarLink.TabIndex = 4;
            btnGerarLink.Text = "Enviar mensagem";
            btnGerarLink.UseVisualStyleBackColor = true;
            btnGerarLink.Click += btnGerarLink_Click;
            // 
            // NumMin
            // 
            NumMin.Anchor = AnchorStyles.None;
            NumMin.Location = new Point(180, 104);
            NumMin.Margin = new Padding(0);
            NumMin.Name = "NumMin";
            NumMin.Size = new Size(63, 23);
            NumMin.TabIndex = 2;
            NumMin.TextAlign = HorizontalAlignment.Center;
            // 
            // UC_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_2";
            Size = new Size(424, 301);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txtTelefone;
        private Button btnGerarLink;
        private TextBox NumMin;
        private Label label3;
    }
}
