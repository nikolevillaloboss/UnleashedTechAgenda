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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ConfirmarCita_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // Crea una instancia de Form2
            form4.Show(); // Muestra Form2
            this.Hide();
        }

        private void CerrarBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InicioBox_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
        }
    }
}
