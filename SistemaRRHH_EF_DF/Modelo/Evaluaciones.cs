using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo
{
    public partial class Evaluaciones
    {
        public Evaluaciones()
        {
            EvaluacionesTipos = new HashSet<EvaluacionesTipos>();
        }

        public int Numero { get; set; }
        public string Descripcion { get; set; }
        public string Resultado { get; set; }
        public DateTime? FechaEvaluacion { get; set; }
        public string Profesional { get; set; }

        public virtual ICollection<EvaluacionesTipos> EvaluacionesTipos { get; set; }
    }
}
