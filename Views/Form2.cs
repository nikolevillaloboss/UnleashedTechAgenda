using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnleashedTechAgenda.Models;

namespace UnleashedTechAgenda.Views
{
    public partial class Form2 : Form
    {
        private UnleashedCitasContext context;
        public Form2()
        {
           

            // conexion a la base de datos
            context = new UnleashedCitasContext();

            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarServicios();
            CargarEspecialista();
           

        }

        

        private void CargarEspecialista()
        {
            //traigo los inserts que existen en la tabla en modo listo para el combobox
            var Especialista = context.Especialista.ToList();
            EspecialistaBox.DataSource = Especialista;
            EspecialistaBox.DisplayMember = "Nombre";

        }
        private void CargarServicios()
        {
            var servicios = context.Servicios.ToList();
            ServicioBox1.DataSource = servicios;
            ServicioBox1.DisplayMember = "NombreServicio";


        }
        private void AgendaButton_Click(object sender, EventArgs e)
        {
           //se crea un objeto de la clase cita que se guarda en la base de datos cada vez que se presiona el agendabutton
           Cita nuevaCita = new Cita
            {
                Idespecialista = EspecialistaBox.SelectedIndex,
                Idservicio = ServicioBox1.SelectedIndex,
               Inicio = dateTimePicker.Value,
               Fin = dateTimePicker.Value.AddMinutes(30),
            };

            context.Cita.Add(nuevaCita);
            context.SaveChanges();
            

            Form3 form3 = new Form3(); // Crea una instancia de Form2
            form3.Show(); // Muestra Form2
            this.Hide();
        }

        private void CerrarBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ServicioBox1_SelectedIndexChanged(object sender, EventArgs e)
       {
            var servicioSeleccionado = ServicioBox1.SelectedItem as Servicio;

        }

        private void EspecialistaBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }
      

    }
}
