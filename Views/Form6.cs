using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnleashedTechAgenda.Models;

namespace UnleashedTechAgenda.Views
{

    public partial class Form6 : Form
    {
        private UnleashedCitasContext context;
        public Form6()
        {
            InitializeComponent();
            context = new UnleashedCitasContext();
        }

        private void Form6_Load(object sender, EventArgs e)
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
            ServicioBox.DataSource = servicios;
            ServicioBox.DisplayMember = "NombreServicio";


        }

        private void EspecialistaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var especialistaSeleccionado = EspecialistaBox.SelectedItem as Especialista;
        }

        private void ServicioBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            var servicioSeleccionado = ServicioBox.SelectedItem as Servicio;
        }

        private void AgendarButton_Click(object sender, EventArgs e)
        {
            var especialistaSeleccionado = EspecialistaBox.SelectedItem as Especialista;
            var servicioSeleccionado = ServicioBox.SelectedItem as Servicio;

            if (especialistaSeleccionado != null && servicioSeleccionado != null)
            {
                long cedulaUsuario = ((Form1)Application.OpenForms["Form1"]).ObtenerCedulaUsuario();

                var usuario = context.Usuarios.FirstOrDefault(u => u.Cedula == cedulaUsuario);

                if (usuario != null)
                {
                    // Buscar el ID del servicio basado en el nombre seleccionado en el ComboBox
                    var idServicio = context.Servicios
                                            .Where(s => s.NombreServicio == servicioSeleccionado.NombreServicio)
                                            .Select(s => s.Id)
                                            .FirstOrDefault();

                    // Buscar el ID del especialista basado en el nombre seleccionado en el ComboBox
                    var idEspecialista = context.Especialista
                                                 .Where(e => e.Nombre == especialistaSeleccionado.Nombre)
                                                 .Select(e => e.Id)
                                                 .FirstOrDefault();

                    Cita nuevaCita = new Cita
                    {
                        Inicio = InicioDateTime.Value,
                        Fin = FinDateTime.Value,
                        CedulaUsuario = cedulaUsuario,
                        Estado = "Pendiente",
                        Idespecialista = idEspecialista,
                        Idservicio = idServicio
                    };

                    context.Cita.Add(nuevaCita);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("El usuario con la cédula proporcionada no fue encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un especialista y un servicio.");
            }

            Form3 form3 = new Form3(); // Crea una instancia de Form5
            form3.Show(); // Muestra Form5
            this.Hide();
        }

        private void InicioDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FinDateTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}




