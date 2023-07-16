using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo1
{
    public partial class OfertasLaborales
    {
        public OfertasLaborales()
        {
            OlClientes = new HashSet<OlClientes>();
            OlConsultorAsignado = new HashSet<OlConsultorAsignado>();
            OlEstados = new HashSet<OlEstados>();
            OlPerfiles = new HashSet<OlPerfiles>();
            OlPostulantes = new HashSet<OlPostulantes>();
            OlRequisitos = new HashSet<OlRequisitos>();
        }

        public int Numero { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public DateTime? FechaCierre { get; set; }

        public virtual ICollection<OlClientes> OlClientes { get; set; }
        public virtual ICollection<OlConsultorAsignado> OlConsultorAsignado { get; set; }
        public virtual ICollection<OlEstados> OlEstados { get; set; }
        public virtual ICollection<OlPerfiles> OlPerfiles { get; set; }
        public virtual ICollection<OlPostulantes> OlPostulantes { get; set; }
        public virtual ICollection<OlRequisitos> OlRequisitos { get; set; }
    }
}
