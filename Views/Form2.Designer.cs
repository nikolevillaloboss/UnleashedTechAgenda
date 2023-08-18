namespace UnleashedTechAgenda.Views
{
    partial class Form2
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

        private DateTimePicker GetDateTimePicker()
        {
            return dateTimePicker;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(DateTimePicker dateTimePicker)
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            AgendaButton = new Button();
            Panel2 = new Panel();
            CerrarBox2 = new PictureBox();
            dateTimePicker = new DateTimePicker();
            ServicioBox1 = new ComboBox();
            especialistaBindingSource = new BindingSource(components);
            EspecialistaBox = new ComboBox();
            ServicioLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            HorarioLabel = new Label();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CerrarBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)especialistaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AgendaButton
            // 
            AgendaButton.BackColor = SystemColors.ControlText;
            AgendaButton.Cursor = Cursors.Hand;
            AgendaButton.ForeColor = SystemColors.ButtonFace;
            AgendaButton.Location = new Point(1057, 483);
            AgendaButton.Name = "AgendaButton";
            AgendaButton.Size = new Size(152, 54);
            AgendaButton.TabIndex = 0;
            AgendaButton.Text = "Agendar";
            AgendaButton.UseVisualStyleBackColor = false;
            AgendaButton.Click += AgendaButton_Click;
            // 
            // Panel2
            // 
            Panel2.BackColor = SystemColors.ActiveCaptionText;
            Panel2.Controls.Add(CerrarBox2);
            Panel2.Dock = DockStyle.Top;
            Panel2.Location = new Point(0, 0);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1282, 35);
            Panel2.TabIndex = 3;
            // 
            // CerrarBox2
            // 
            CerrarBox2.Cursor = Cursors.Hand;
            CerrarBox2.Image = (Image)resources.GetObject("CerrarBox2.Image");
            CerrarBox2.Location = new Point(1243, 3);
            CerrarBox2.Name = "CerrarBox2";
            CerrarBox2.Size = new Size(36, 29);
            CerrarBox2.SizeMode = PictureBoxSizeMode.Zoom;
            CerrarBox2.TabIndex = 0;
            CerrarBox2.TabStop = false;
            CerrarBox2.Click += CerrarBox2_Click;
            // 
            // dateTimePicker
            // 
           
            // 
            // ServicioBox1
            // 
            ServicioBox1.DataSource = especialistaBindingSource;
            ServicioBox1.FormattingEnabled = true;
            ServicioBox1.Location = new Point(831, 129);
            ServicioBox1.Name = "ServicioBox1";
            ServicioBox1.Size = new Size(397, 28);
            ServicioBox1.TabIndex = 6;
            ServicioBox1.SelectedIndexChanged += ServicioBox1_SelectedIndexChanged;
            // 
            // especialistaBindingSource
            // 
            especialistaBindingSource.DataSource = typeof(Models.Especialista);
            // 
            // EspecialistaBox
            // 
            EspecialistaBox.FormattingEnabled = true;
            EspecialistaBox.Location = new Point(831, 189);
            EspecialistaBox.Name = "EspecialistaBox";
            EspecialistaBox.Size = new Size(400, 28);
            EspecialistaBox.TabIndex = 7;
            EspecialistaBox.SelectedIndexChanged += EspecialistaBox_SelectedIndexChanged;
            // 
            // ServicioLabel
            // 
            ServicioLabel.AutoSize = true;
            ServicioLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ServicioLabel.ForeColor = SystemColors.ButtonFace;
            ServicioLabel.Location = new Point(528, 123);
            ServicioLabel.Name = "ServicioLabel";
            ServicioLabel.Size = new Size(250, 32);
            ServicioLabel.TabIndex = 8;
            ServicioLabel.Text = "Seleccione un servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(528, 189);
            label2.Name = "label2";
            label2.Size = new Size(291, 32);
            label2.TabIndex = 9;
            label2.Text = "Seleccione un especialista";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(769, 288);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // HorarioLabel
            // 
            HorarioLabel.AutoSize = true;
            HorarioLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            HorarioLabel.ForeColor = SystemColors.ButtonFace;
            HorarioLabel.Location = new Point(528, 276);
            HorarioLabel.Name = "HorarioLabel";
            HorarioLabel.Size = new Size(93, 32);
            HorarioLabel.TabIndex = 11;
            HorarioLabel.Text = "Horario";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1282, 603);
            Controls.Add(HorarioLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ServicioLabel);
            Controls.Add(EspecialistaBox);
            Controls.Add(ServicioBox1);
            Controls.Add(dateTimePicker);
            Controls.Add(Panel2);
            Controls.Add(AgendaButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CerrarBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)especialistaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AgendaButton;
        private Panel Panel2;
        private PictureBox CerrarBox2;
        private DateTimePicker dateTimePicker;
        private ComboBox ServicioBox1;
        private ComboBox EspecialistaBox;
        private Label ServicioLabel;
        private Label label2;
        private Label label3;
        private Label HorarioLabel;
        private BindingSource especialistaBindingSource;
    }
}