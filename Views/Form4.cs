using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnleashedTechAgenda.Views
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); // Crea una instancia de Form2
            form5.Show(); // Muestra Form2
            this.Hide();
        }

        private void CerrarBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InicioBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
        }
    }
}
