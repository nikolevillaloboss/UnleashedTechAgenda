namespace UnleashedTechAgenda.Views
{
    partial class Form6
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
            EspecialistaBox = new ComboBox();
            ServicioBox = new ComboBox();
            AgendarButton = new Button();
            InicioDateTime = new DateTimePicker();
            FinDateTime = new DateTimePicker();
            SuspendLayout();
            // 
            // EspecialistaBox
            // 
            EspecialistaBox.FormattingEnabled = true;
            EspecialistaBox.Location = new Point(1007, 95);
            EspecialistaBox.Name = "EspecialistaBox";
            EspecialistaBox.Size = new Size(209, 28);
            EspecialistaBox.TabIndex = 0;
            EspecialistaBox.SelectedIndexChanged += EspecialistaBox_SelectedIndexChanged;
            // 
            // ServicioBox
            // 
            ServicioBox.FormattingEnabled = true;
            ServicioBox.Location = new Point(1007, 167);
            ServicioBox.Name = "ServicioBox";
            ServicioBox.Size = new Size(209, 28);
            ServicioBox.TabIndex = 1;
            ServicioBox.SelectedIndexChanged += ServicioBox_SelectedIndexChanged_1;
            // 
            // AgendarButton
            // 
            AgendarButton.Location = new Point(1055, 335);
            AgendarButton.Name = "AgendarButton";
            AgendarButton.Size = new Size(161, 42);
            AgendarButton.TabIndex = 2;
            AgendarButton.Text = "Agendar";
            AgendarButton.UseVisualStyleBackColor = true;
            AgendarButton.Click += AgendarButton_Click;
            // 
            // InicioDateTime
            // 
            InicioDateTime.Location = new Point(966, 227);
            InicioDateTime.Name = "InicioDateTime";
            InicioDateTime.Size = new Size(250, 27);
            InicioDateTime.TabIndex = 3;
            InicioDateTime.ValueChanged += InicioDateTime_ValueChanged;
            // 
            // FinDateTime
            // 
            FinDateTime.Location = new Point(967, 280);
            FinDateTime.Name = "FinDateTime";
            FinDateTime.Size = new Size(250, 27);
            FinDateTime.TabIndex = 4;
            FinDateTime.ValueChanged += FinDateTime_ValueChanged;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 603);
            Controls.Add(FinDateTime);
            Controls.Add(InicioDateTime);
            Controls.Add(AgendarButton);
            Controls.Add(ServicioBox);
            Controls.Add(EspecialistaBox);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
        }

        private void ServicioBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox EspecialistaBox;
        private ComboBox ServicioBox;
        private Button AgendarButton;
        private DateTimePicker InicioDateTime;
        private DateTimePicker FinDateTime;
    }
}