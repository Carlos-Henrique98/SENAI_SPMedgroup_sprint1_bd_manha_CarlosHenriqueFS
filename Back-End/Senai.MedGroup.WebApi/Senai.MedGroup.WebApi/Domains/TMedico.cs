using System;
using System.Collections.Generic;

namespace Senai.MedGroup.WebApi.Domains
{
    public partial class TMedico
    {
        public TMedico()
        {
            TConsulta = new HashSet<TConsulta>();
        }

        public int IdMedico { get; set; }
        public string NomeMedico { get; set; }
        public string Crm { get; set; }
        public string Genero { get; set; }
        public int? IdClinica { get; set; }
        public int? IdEspecialidade { get; set; }
        public int? IdUsuario { get; set; }

        public TClinica IdClinicaNavigation { get; set; }
        public TEspecialidade IdEspecialidadeNavigation { get; set; }
        public TUsuario IdUsuarioNavigation { get; set; }
        public ICollection<TConsulta> TConsulta { get; set; }
    }
}
