using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo1
{
    public partial class Consultores
    {
        public Consultores()
        {
            OlConsultorAsignado = new HashSet<OlConsultorAsignado>();
        }

        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<OlConsultorAsignado> OlConsultorAsignado { get; set; }
    }
}
