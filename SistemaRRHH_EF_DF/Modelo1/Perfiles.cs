using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo1
{
    public partial class Perfiles
    {
        public Perfiles()
        {
            EntrevistasPerfiles = new HashSet<EntrevistasPerfiles>();
            OlPerfiles = new HashSet<OlPerfiles>();
            PerfilesPostulantes = new HashSet<PerfilesPostulantes>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<EntrevistasPerfiles> EntrevistasPerfiles { get; set; }
        public virtual ICollection<OlPerfiles> OlPerfiles { get; set; }
        public virtual ICollection<PerfilesPostulantes> PerfilesPostulantes { get; set; }
    }
}
