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
            lblLinkGerado = new LinkLabel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTelefone = new TextBox();
            btnGerarLink = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLinkGerado
            // 
            lblLinkGerado.AutoSize = true;
            lblLinkGerado.Location = new Point(58, 150);
            lblLinkGerado.Margin = new Padding(4, 0, 4, 0);
            lblLinkGerado.Name = "lblLinkGerado";
            lblLinkGerado.Size = new Size(0, 15);
            lblLinkGerado.TabIndex = 3;
            lblLinkGerado.Visible = false;
            lblLinkGerado.LinkClicked += lblLinkGerado_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 33);
            label1.Name = "label1";
            label1.Size = new Size(170, 24);
            label1.TabIndex = 4;
            label1.Text = "Insira o número";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtTelefone, 0, 1);
            tableLayoutPanel1.Controls.Add(btnGerarLink, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(334, 211);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.None;
            txtTelefone.Location = new Point(89, 73);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(155, 23);
            txtTelefone.TabIndex = 1;
            // 
            // btnGerarLink
            // 
            btnGerarLink.Anchor = AnchorStyles.None;
            btnGerarLink.Location = new Point(108, 103);
            btnGerarLink.Margin = new Padding(4, 3, 4, 3);
            btnGerarLink.Name = "btnGerarLink";
            btnGerarLink.Size = new Size(117, 24);
            btnGerarLink.TabIndex = 2;
            btnGerarLink.Text = "Enviar mensagem";
            btnGerarLink.UseVisualStyleBackColor = true;
            btnGerarLink.Click += btnGerarLink_Click;
            // 
            // Form1
            // 
            AcceptButton = btnGerarLink;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 211);
            Controls.Add(lblLinkGerado);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(250, 150);
            Name = "Form1";
            Text = "WhatsLink";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.LinkLabel lblLinkGerado;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtTelefone;
        private Button btnGerarLink;
    }
}