namespace UnleashedTechAgenda.Views
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            textBox1 = new TextBox();
            ConsultarButton = new Button();
            IdLabel = new Label();
            Panel4 = new Panel();
            InicioBox4 = new PictureBox();
            CerrarBox4 = new PictureBox();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InicioBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CerrarBox4).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(364, 270);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(509, 27);
            textBox1.TabIndex = 0;
            // 
            // ConsultarButton
            // 
            ConsultarButton.BackColor = Color.Black;
            ConsultarButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ConsultarButton.ForeColor = Color.Snow;
            ConsultarButton.Location = new Point(524, 388);
            ConsultarButton.Name = "ConsultarButton";
            ConsultarButton.Size = new Size(174, 52);
            ConsultarButton.TabIndex = 1;
            ConsultarButton.Text = "Consultar";
            ConsultarButton.UseVisualStyleBackColor = false;
            ConsultarButton.Click += ConsultarButton_Click;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            IdLabel.ForeColor = SystemColors.ButtonFace;
            IdLabel.Location = new Point(331, 147);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(613, 60);
            IdLabel.TabIndex = 2;
            IdLabel.Text = "Ingrese el Id de su reservación";
            // 
            // Panel4
            // 
            Panel4.Controls.Add(InicioBox4);
            Panel4.Controls.Add(CerrarBox4);
            Panel4.Dock = DockStyle.Top;
            Panel4.ForeColor = Color.Snow;
            Panel4.Location = new Point(0, 0);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1282, 35);
            Panel4.TabIndex = 3;
            // 
            // InicioBox4
            // 
            InicioBox4.Image = Properties.Resources.WhatsApp_Image_2023_08_09_at_12_02_37_01;
            InicioBox4.Location = new Point(12, 0);
            InicioBox4.Name = "InicioBox4";
            InicioBox4.Size = new Size(125, 28);
            InicioBox4.SizeMode = PictureBoxSizeMode.Zoom;
            InicioBox4.TabIndex = 1;
            InicioBox4.TabStop = false;
            InicioBox4.Click += InicioBox4_Click;
            // 
            // CerrarBox4
            // 
            CerrarBox4.Image = (Image)resources.GetObject("CerrarBox4.Image");
            CerrarBox4.Location = new Point(1230, 5);
            CerrarBox4.Name = "CerrarBox4";
            CerrarBox4.Size = new Size(40, 27);
            CerrarBox4.SizeMode = PictureBoxSizeMode.Zoom;
            CerrarBox4.TabIndex = 0;
            CerrarBox4.TabStop = false;
            CerrarBox4.Click += CerrarBox4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1282, 603);
            Controls.Add(Panel4);
            Controls.Add(IdLabel);
            Controls.Add(ConsultarButton);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InicioBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)CerrarBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button ConsultarButton;
        private Label IdLabel;
        private Panel Panel4;
        private PictureBox CerrarBox4;
        private PictureBox InicioBox4;
    }
}