using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo1
{
    public partial class EvaluacionesTipos
    {
        public int NroEvaluacion { get; set; }
        public int IdTipo { get; set; }

        public virtual TipoEvaluaciones IdTipoNavigation { get; set; }
        public virtual Evaluaciones NroEvaluacionNavigation { get; set; }
    }
}
