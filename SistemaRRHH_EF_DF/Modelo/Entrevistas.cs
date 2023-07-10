using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo
{
    public partial class Entrevistas
    {
        public Entrevistas()
        {
            EntrevistasPerfiles = new HashSet<EntrevistasPerfiles>();
            Turnos = new HashSet<Turnos>();
        }

        public int Numero { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<EntrevistasPerfiles> EntrevistasPerfiles { get; set; }
        public virtual ICollection<Turnos> Turnos { get; set; }
    }
}
