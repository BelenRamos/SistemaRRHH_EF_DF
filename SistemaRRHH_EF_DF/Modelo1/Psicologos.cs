using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo1
{
    public partial class Psicologos
    {
        public Psicologos()
        {
            Turnos = new HashSet<Turnos>();
        }

        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual ICollection<Turnos> Turnos { get; set; }
    }
}
