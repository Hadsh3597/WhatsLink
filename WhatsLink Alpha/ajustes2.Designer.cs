namespace WhatsLink_Alpha
{
    partial class ajustes2
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
            buttonSalvar = new Button();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtTempoB = new TextBox();
            txtTempoA = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblLinkGerado = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ExampleLabel = new Label();
            label5 = new Label();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.None;
            buttonSalvar.Cursor = Cursors.Hand;
            buttonSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvar.Location = new Point(339, 498);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(164, 36);
            buttonSalvar.TabIndex = 2;
            buttonSalvar.Text = "Salvar ";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(548, 2);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 1;
            label2.Text = "Texto após os minutos";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(124, 2);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 0;
            label3.Text = "Texto antes dos minutos";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 148);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(836, 24);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // txtTempoB
            // 
            txtTempoB.Anchor = AnchorStyles.None;
            txtTempoB.BorderStyle = BorderStyle.FixedSingle;
            txtTempoB.Cursor = Cursors.IBeam;
            txtTempoB.Location = new Point(432, 3);
            txtTempoB.Multiline = true;
            txtTempoB.Name = "txtTempoB";
            txtTempoB.ScrollBars = ScrollBars.Vertical;
            txtTempoB.Size = new Size(390, 58);
            txtTempoB.TabIndex = 1;
            // 
            // txtTempoA
            // 
            txtTempoA.Anchor = AnchorStyles.None;
            txtTempoA.BackColor = SystemColors.Window;
            txtTempoA.BorderStyle = BorderStyle.FixedSingle;
            txtTempoA.Cursor = Cursors.IBeam;
            txtTempoA.Location = new Point(24, 3);
            txtTempoA.Multiline = true;
            txtTempoA.Name = "txtTempoA";
            txtTempoA.Size = new Size(370, 58);
            txtTempoA.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(txtTempoB, 1, 0);
            tableLayoutPanel2.Controls.Add(txtTempoA, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 78);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(836, 64);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // lblLinkGerado
            // 
            lblLinkGerado.AutoSize = true;
            lblLinkGerado.Location = new Point(-9, 150);
            lblLinkGerado.Margin = new Padding(4, 0, 4, 0);
            lblLinkGerado.Name = "lblLinkGerado";
            lblLinkGerado.Size = new Size(0, 15);
            lblLinkGerado.TabIndex = 16;
            lblLinkGerado.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.Control;
            linkLabel1.Location = new Point(-9, 150);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 21);
            label1.Name = "label1";
            label1.Size = new Size(482, 32);
            label1.TabIndex = 1;
            label1.Text = "Configurar mensagens automaticas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonSalvar, 0, 9);
            tableLayoutPanel1.Controls.Add(ExampleLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.52174F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.4782639F));
            tableLayoutPanel1.Size = new Size(842, 621);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ExampleLabel
            // 
            ExampleLabel.Anchor = AnchorStyles.None;
            ExampleLabel.AutoSize = true;
            ExampleLabel.BorderStyle = BorderStyle.FixedSingle;
            ExampleLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExampleLabel.Location = new Point(386, 229);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new Size(69, 22);
            ExampleLabel.TabIndex = 2;
            ExampleLabel.Text = "Exemplo";
            ExampleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(380, 180);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 1;
            label5.Text = "EXEMPLO:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ajustes2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblLinkGerado);
            Controls.Add(linkLabel1);
            Controls.Add(tableLayoutPanel1);
            Name = "ajustes2";
            Size = new Size(842, 621);
            Load += UC_ajustes_Load;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalvar;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtTempoB;
        private TextBox txtTempoA;
        private TableLayoutPanel tableLayoutPanel2;
        private LinkLabel lblLinkGerado;
        private LinkLabel linkLabel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ExampleLabel;
        private Label label5;
    }
}
