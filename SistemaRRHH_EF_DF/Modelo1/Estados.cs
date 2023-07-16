using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo1
{
    public partial class Estados
    {
        public Estados()
        {
            OlEstados = new HashSet<OlEstados>();
        }

        public int Codigo { get; set; }
        public string Designacion { get; set; }

        public virtual ICollection<OlEstados> OlEstados { get; set; }
    }
}
