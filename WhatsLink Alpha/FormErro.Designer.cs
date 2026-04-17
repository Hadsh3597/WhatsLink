namespace WhatsLink_Alpha
{
    partial class FormErro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTNok = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTNok
            // 
            BTNok.Location = new Point(110, 79);
            BTNok.Name = "BTNok";
            BTNok.Size = new Size(75, 23);
            BTNok.TabIndex = 0;
            BTNok.Text = "OK";
            BTNok.UseVisualStyleBackColor = true;
            BTNok.Click += BTNok_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 38);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 2;
            label1.Text = "Task failed successfully.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.recreated_windows_7_icons_and_ui_on_svg_v0_q6wbd41ktaqg1_removebg_preview;
            pictureBox1.Location = new Point(15, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormErro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(197, 114);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(BTNok);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormErro";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Error";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNok;
        private Label label1;
        private PictureBox pictureBox1;
    }
}