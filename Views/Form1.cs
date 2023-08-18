using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnleashedTechAgenda.Models;

namespace UnleashedTechAgenda.Views
{
    public partial class Form1 : Form
    {
        private UnleashedCitasContext context;

        public Form1()
        {
            InitializeComponent();
            context = new UnleashedCitasContext();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            SiguienteButton = new Button();
            CedulaLabel = new Label();
            NombreLabel = new Label();
            ApellidoLabel = new Label();
            CorreoLabel = new Label();
            CedulaBox = new TextBox();
            NombreBox = new TextBox();
            ApellidoBox = new TextBox();
            CorreoBox = new TextBox();
            PanelHeader = new Panel();
            VistaBox = new PictureBox();
            MaximizarBox = new PictureBox();
            pictureBox2 = new PictureBox();
            CerrarBox = new PictureBox();
            MenuPanel = new Panel();
            CitaTxt = new Label();
            UnleashedLabel = new Label();
            button1 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            PanelHeader.SuspendLayout();
            ((ISupportInitialize)VistaBox).BeginInit();
            ((ISupportInitialize)MaximizarBox).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)CerrarBox).BeginInit();
            MenuPanel.SuspendLayout();
            ((ISupportInitialize)pictureBox5).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // SiguienteButton
            // 
            SiguienteButton.BackColor = Color.Black;
            SiguienteButton.Cursor = Cursors.Hand;
            SiguienteButton.ForeColor = SystemColors.ButtonHighlight;
            SiguienteButton.Location = new Point(1046, 525);
            SiguienteButton.Name = "SiguienteButton";
            SiguienteButton.Size = new Size(173, 51);
            SiguienteButton.TabIndex = 0;
            SiguienteButton.Text = "Siguiente";
            SiguienteButton.UseVisualStyleBackColor = false;
            SiguienteButton.Click += SiguienteButton_Click;
            // 
            // CedulaLabel
            // 
            CedulaLabel.AutoSize = true;
            CedulaLabel.BackColor = SystemColors.ActiveCaptionText;
            CedulaLabel.ForeColor = SystemColors.ButtonFace;
            CedulaLabel.Location = new Point(859, 141);
            CedulaLabel.Name = "CedulaLabel";
            CedulaLabel.Size = new Size(55, 20);
            CedulaLabel.TabIndex = 1;
            CedulaLabel.Text = "Cédula";
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.BackColor = SystemColors.ActiveCaptionText;
            NombreLabel.ForeColor = SystemColors.ButtonFace;
            NombreLabel.Location = new Point(860, 220);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(64, 20);
            NombreLabel.TabIndex = 2;
            NombreLabel.Text = "Nombre";
            // 
            // ApellidoLabel
            // 
            ApellidoLabel.AutoSize = true;
            ApellidoLabel.BackColor = SystemColors.ActiveCaptionText;
            ApellidoLabel.ForeColor = SystemColors.ButtonFace;
            ApellidoLabel.Location = new Point(860, 282);
            ApellidoLabel.Name = "ApellidoLabel";
            ApellidoLabel.Size = new Size(66, 20);
            ApellidoLabel.TabIndex = 3;
            ApellidoLabel.Text = "Apellido";
            // 
            // CorreoLabel
            // 
            CorreoLabel.AutoSize = true;
            CorreoLabel.BackColor = SystemColors.ActiveCaptionText;
            CorreoLabel.ForeColor = SystemColors.ButtonFace;
            CorreoLabel.Location = new Point(860, 353);
            CorreoLabel.Name = "CorreoLabel";
            CorreoLabel.Size = new Size(54, 20);
            CorreoLabel.TabIndex = 4;
            CorreoLabel.Text = "Correo";
            // 
            // CedulaBox
            // 
            CedulaBox.BackColor = SystemColors.ActiveCaptionText;
            CedulaBox.ForeColor = SystemColors.ButtonFace;
            CedulaBox.Location = new Point(858, 111);
            CedulaBox.Name = "CedulaBox";
            CedulaBox.Size = new Size(373, 27);
            CedulaBox.TabIndex = 5;
            CedulaBox.TextChanged += CedulaBox_TextChanged;
            // 
            // NombreBox
            // 
            NombreBox.BackColor = SystemColors.ActiveCaptionText;
            NombreBox.ForeColor = SystemColors.ButtonFace;
            NombreBox.Location = new Point(859, 190);
            NombreBox.Name = "NombreBox";
            NombreBox.Size = new Size(373, 27);
            NombreBox.TabIndex = 6;
            NombreBox.TextChanged += NombreBox_TextChanged;
            // 
            // ApellidoBox
            // 
            ApellidoBox.BackColor = SystemColors.ActiveCaptionText;
            ApellidoBox.ForeColor = SystemColors.ButtonFace;
            ApellidoBox.Location = new Point(860, 252);
            ApellidoBox.Name = "ApellidoBox";
            ApellidoBox.Size = new Size(373, 27);
            ApellidoBox.TabIndex = 7;
            ApellidoBox.TextChanged += ApellidoBox_TextChanged;
            // 
            // CorreoBox
            // 
            CorreoBox.BackColor = SystemColors.ActiveCaptionText;
            CorreoBox.ForeColor = SystemColors.ButtonFace;
            CorreoBox.Location = new Point(858, 323);
            CorreoBox.Name = "CorreoBox";
            CorreoBox.Size = new Size(373, 27);
            CorreoBox.TabIndex = 8;
            CorreoBox.TextChanged += CorreoBox_TextChanged;
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = SystemColors.ActiveCaptionText;
            PanelHeader.Controls.Add(VistaBox);
            PanelHeader.Controls.Add(MaximizarBox);
            PanelHeader.Controls.Add(pictureBox2);
            PanelHeader.Controls.Add(CerrarBox);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1300, 35);
            PanelHeader.TabIndex = 9;
            // 
            // VistaBox
            // 
            VistaBox.Cursor = Cursors.Hand;
            VistaBox.Image = Properties.Resources.minimizar__1_;
            VistaBox.Location = new Point(1185, 3);
            VistaBox.Name = "VistaBox";
            VistaBox.Size = new Size(34, 32);
            VistaBox.SizeMode = PictureBoxSizeMode.Zoom;
            VistaBox.TabIndex = 3;
            VistaBox.TabStop = false;
            VistaBox.Click += VistaBox_Click;
            // 
            // MaximizarBox
            // 
            MaximizarBox.Cursor = Cursors.Hand;
            MaximizarBox.Image = (Image)resources.GetObject("MaximizarBox.Image");
            MaximizarBox.Location = new Point(1222, 3);
            MaximizarBox.Name = "MaximizarBox";
            MaximizarBox.Size = new Size(32, 29);
            MaximizarBox.SizeMode = PictureBoxSizeMode.Zoom;
            MaximizarBox.TabIndex = 2;
            MaximizarBox.TabStop = false;
            MaximizarBox.Click += MaximizarBox_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(196, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // CerrarBox
            // 
            CerrarBox.Cursor = Cursors.Hand;
            CerrarBox.Image = (Image)resources.GetObject("CerrarBox.Image");
            CerrarBox.Location = new Point(1260, 3);
            CerrarBox.Name = "CerrarBox";
            CerrarBox.Size = new Size(28, 29);
            CerrarBox.SizeMode = PictureBoxSizeMode.Zoom;
            CerrarBox.TabIndex = 0;
            CerrarBox.TabStop = false;
            CerrarBox.Click += CerrarBox_Click;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(64, 64, 64);
            MenuPanel.Controls.Add(CitaTxt);
            MenuPanel.Controls.Add(UnleashedLabel);
            MenuPanel.Controls.Add(button1);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 35);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(574, 615);
            MenuPanel.TabIndex = 10;
            // 
            // CitaTxt
            // 
            CitaTxt.AutoSize = true;
            CitaTxt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CitaTxt.ForeColor = Color.Snow;
            CitaTxt.Location = new Point(29, 96);
            CitaTxt.Name = "CitaTxt";
            CitaTxt.Size = new Size(258, 41);
            CitaTxt.TabIndex = 2;
            CitaTxt.Text = "Ya tienes una cita?";
            // 
            // UnleashedLabel
            // 
            UnleashedLabel.AutoSize = true;
            UnleashedLabel.BackColor = Color.Transparent;
            UnleashedLabel.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            UnleashedLabel.ForeColor = Color.Snow;
            UnleashedLabel.Location = new Point(12, 34);
            UnleashedLabel.Name = "UnleashedLabel";
            UnleashedLabel.Size = new Size(548, 44);
            UnleashedLabel.TabIndex = 1;
            UnleashedLabel.Text = "Bienvenido a Unleashed Tech";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(367, 490);
            button1.Name = "button1";
            button1.Size = new Size(135, 42);
            button1.TabIndex = 0;
            button1.Text = "Ver cita";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(806, 190);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(800, 111);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(806, 252);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 36);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(806, 323);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(35, 47);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1300, 650);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(MenuPanel);
            Controls.Add(PanelHeader);
            Controls.Add(CorreoBox);
            Controls.Add(ApellidoBox);
            Controls.Add(NombreBox);
            Controls.Add(CedulaBox);
            Controls.Add(CorreoLabel);
            Controls.Add(ApellidoLabel);
            Controls.Add(NombreLabel);
            Controls.Add(CedulaLabel);
            Controls.Add(SiguienteButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Load += Form1_Load;
            PanelHeader.ResumeLayout(false);
            ((ISupportInitialize)VistaBox).EndInit();
            ((ISupportInitialize)MaximizarBox).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)CerrarBox).EndInit();
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CerrarBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizarBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            MaximizarBox.Visible = false;

        }

        private void VistaBox_Click(object sender, EventArgs e)
        {
            this.WindowState |= FormWindowState.Minimized;
        }

        private void SiguienteButton_Click(object sender, EventArgs e)
        {
            if (CamposCompletos())
            {
                long cedula;
                if (long.TryParse(CedulaBox.Text, out cedula))
                {
                    Usuario nuevoUsuario = new Usuario
                    {
                        Cedula = cedula,
                        Nombre = NombreBox.Text,
                        Apellido = ApellidoBox.Text,
                        CorreoElectronico = CorreoBox.Text
                    };

                    context.Usuarios.Add(nuevoUsuario);
                    context.SaveChanges();

                    Form6 form6 = new Form6(); // Crea una instancia de Form2
                    form6.Show(); // Muestra Form2
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("Parece que hay un error, por favor completa todos los campos");
            }
        }
        private bool CamposCompletos()
        {
            if (string.IsNullOrWhiteSpace(CedulaBox.Text) ||
                string.IsNullOrWhiteSpace(NombreBox.Text) ||
                string.IsNullOrWhiteSpace(ApellidoBox.Text) ||
                string.IsNullOrWhiteSpace(CorreoBox.Text))
            {
                return false; // Faltan campos por completar
            }

            return true; // Todos los campos están completos
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); // Crea una instancia de Form5
            form5.Show(); // Muestra Form5
            this.Hide(); 
        }

        private void CedulaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CorreoBox_TextChanged(object sender, EventArgs e)
        {

        }

        public long ObtenerCedulaUsuario() {
            long cedula;
            if(long.TryParse(CedulaBox.Text, out cedula))
            {

                return cedula;  
            }

            return 0;
        
        
        }
    }
}
