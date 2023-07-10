using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo
{
    public partial class TipoEvaluaciones
    {
        public TipoEvaluaciones()
        {
            EvaluacionesTipos = new HashSet<EvaluacionesTipos>();
        }

        public int Id { get; set; }
        public string Detalle { get; set; }

        public virtual ICollection<EvaluacionesTipos> EvaluacionesTipos { get; set; }
    }
}
