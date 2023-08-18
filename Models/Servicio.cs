using System;
using System.Collections.Generic;

namespace UnleashedTechAgenda.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            Cita = new HashSet<Cita>();
        }

        public int Id { get; set; }
        public string NombreServicio { get; set; } = null!;

        public virtual ICollection<Cita> Cita { get; set; }
    }
}
