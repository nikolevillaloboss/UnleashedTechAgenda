namespace UnleashedTechAgenda.Views
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            AgendaLabel = new Label();
            ConfirmarCita = new Button();
            panel1 = new Panel();
            CerrarBox3 = new PictureBox();
            InicioBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CerrarBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InicioBox).BeginInit();
            SuspendLayout();
            // 
            // AgendaLabel
            // 
            AgendaLabel.AutoSize = true;
            AgendaLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            AgendaLabel.ForeColor = Color.Snow;
            AgendaLabel.Location = new Point(368, 181);
            AgendaLabel.Name = "AgendaLabel";
            AgendaLabel.Size = new Size(550, 62);
            AgendaLabel.TabIndex = 0;
            AgendaLabel.Text = "Su cita ha sido agendada";
            // 
            // ConfirmarCita
            // 
            ConfirmarCita.Location = new Point(545, 366);
            ConfirmarCita.Name = "ConfirmarCita";
            ConfirmarCita.Size = new Size(143, 40);
            ConfirmarCita.TabIndex = 1;
            ConfirmarCita.Text = "Ver cita";
            ConfirmarCita.UseVisualStyleBackColor = true;
            ConfirmarCita.Click += ConfirmarCita_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(InicioBox);
            panel1.Controls.Add(CerrarBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 35);
            panel1.TabIndex = 2;
            // 
            // CerrarBox3
            // 
            CerrarBox3.Image = (Image)resources.GetObject("CerrarBox3.Image");
            CerrarBox3.Location = new Point(1241, 6);
            CerrarBox3.Name = "CerrarBox3";
            CerrarBox3.Size = new Size(29, 26);
            CerrarBox3.SizeMode = PictureBoxSizeMode.Zoom;
            CerrarBox3.TabIndex = 0;
            CerrarBox3.TabStop = false;
            CerrarBox3.Click += CerrarBox3_Click;
            // 
            // InicioBox
            // 
            InicioBox.Image = (Image)resources.GetObject("InicioBox.Image");
            InicioBox.Location = new Point(12, 3);
            InicioBox.Name = "InicioBox";
            InicioBox.Size = new Size(147, 29);
            InicioBox.SizeMode = PictureBoxSizeMode.Zoom;
            InicioBox.TabIndex = 1;
            InicioBox.TabStop = false;
            InicioBox.Click += InicioBox_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1282, 603);
            Controls.Add(panel1);
            Controls.Add(ConfirmarCita);
            Controls.Add(AgendaLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CerrarBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)InicioBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AgendaLabel;
        private Button ConfirmarCita;
        private Panel panel1;
        private PictureBox CerrarBox3;
        private PictureBox InicioBox;
    }
}