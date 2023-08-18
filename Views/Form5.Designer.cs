namespace UnleashedTechAgenda.Views
{
    partial class Form5
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
            InicioLabel = new LinkLabel();
            Panel5 = new Panel();
            BorrarBox5 = new PictureBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BorrarBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // InicioLabel
            // 
            InicioLabel.AutoSize = true;
            InicioLabel.Location = new Point(86, 9);
            InicioLabel.Name = "InicioLabel";
            InicioLabel.Size = new Size(45, 20);
            InicioLabel.TabIndex = 0;
            InicioLabel.TabStop = true;
            InicioLabel.Text = "Inicio";
            InicioLabel.LinkClicked += InicioLabel_LinkClicked;
            // 
            // Panel5
            // 
            Panel5.Controls.Add(BorrarBox5);
            Panel5.Dock = DockStyle.Top;
            Panel5.Location = new Point(0, 0);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(1282, 35);
            Panel5.TabIndex = 1;
            // 
            // BorrarBox5
            // 
            BorrarBox5.Image = Properties.Resources.borrar;
            BorrarBox5.Location = new Point(1228, 0);
            BorrarBox5.Name = "BorrarBox5";
            BorrarBox5.Size = new Size(42, 29);
            BorrarBox5.SizeMode = PictureBoxSizeMode.Zoom;
            BorrarBox5.TabIndex = 0;
            BorrarBox5.TabStop = false;
            BorrarBox5.Click += BorrarBox5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(648, 203);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Location = new Point(477, 423);
            button1.Name = "button1";
            button1.Size = new Size(309, 51);
            button1.TabIndex = 3;
            button1.Text = "Cancelar cita";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1282, 603);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Panel5);
            Controls.Add(InicioLabel);
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BorrarBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel InicioLabel;
        private Panel Panel5;
        private PictureBox BorrarBox5;
        private DataGridView dataGridView1;
        private Button button1;
    }
}