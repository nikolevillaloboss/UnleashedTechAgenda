using System;
using System.Collections.Generic;

namespace UnleashedTechAgenda.Models
{
    public partial class Cita
    {
        public int Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public long? CedulaUsuario { get; set; }
        public string Estado { get; set; } = null!;
        public int? Idespecialista { get; set; }
        public int? Idservicio { get; set; }

        public virtual Usuario? CedulaUsuarioNavigation { get; set; }
        public virtual Especialista? IdespecialistaNavigation { get; set; }
        public virtual Servicio? IdservicioNavigation { get; set; }

        
    }
}
