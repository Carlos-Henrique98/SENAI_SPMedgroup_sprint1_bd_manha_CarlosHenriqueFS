using System;
using System.Collections.Generic;

namespace Senai.MedGroup.WebApi.Domains
{
    public partial class TConsulta
    {
        public int IdConsulta { get; set; }
        public DateTime DataConsulta { get; set; }
        public int? IdMedico { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdSituacao { get; set; }

        public TMedico IdMedicoNavigation { get; set; }
        public TPaciente IdPacienteNavigation { get; set; }
        public TSituacao IdSituacaoNavigation { get; set; }
    }
}
