using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo1
{
    public partial class OlEstados
    {
        public int NroOl { get; set; }
        public int CodigoEstado { get; set; }

        public virtual Estados CodigoEstadoNavigation { get; set; }
        public virtual OfertasLaborales NroOlNavigation { get; set; }
    }
}
