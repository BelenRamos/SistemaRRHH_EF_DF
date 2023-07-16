using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo1
{
    public partial class Postulantes
    {
        public Postulantes()
        {
            EvalucionesPostulantes = new HashSet<EvalucionesPostulantes>();
            OlPostulantes = new HashSet<OlPostulantes>();
            PerfilesPostulantes = new HashSet<PerfilesPostulantes>();
        }

        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public byte? EsCandidato { get; set; }

        public virtual ICollection<EvalucionesPostulantes> EvalucionesPostulantes { get; set; }
        public virtual ICollection<OlPostulantes> OlPostulantes { get; set; }
        public virtual ICollection<PerfilesPostulantes> PerfilesPostulantes { get; set; }
    }
}
