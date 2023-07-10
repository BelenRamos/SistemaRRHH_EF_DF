using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaRRHH_EF_DF.Modelo
{
    public partial class Turnos
    {
        public DateTime Fecha { get; set; }
        public TimeSpan Horario { get; set; }
        public byte? Disponible { get; set; }
        public int? NroEntrevista { get; set; }
        public int MatPsicologo { get; set; }

        public virtual Psicologos MatPsicologoNavigation { get; set; }
        public virtual Entrevistas NroEntrevistaNavigation { get; set; }
    }
}
