using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo
{
    public partial class OlPerfiles
    {
        public int NroOl { get; set; }
        public int IdPerfil { get; set; }

        public virtual Perfiles IdPerfilNavigation { get; set; }
        public virtual OfertasLaborales NroOlNavigation { get; set; }
    }
}
