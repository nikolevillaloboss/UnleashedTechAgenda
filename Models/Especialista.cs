using System;
using System.Collections.Generic;

namespace UnleashedTechAgenda.Models
{
    public partial class Especialista
    {
        public Especialista()
        {
            Cita = new HashSet<Cita>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;

        public virtual ICollection<Cita> Cita { get; set; }
    }
}
