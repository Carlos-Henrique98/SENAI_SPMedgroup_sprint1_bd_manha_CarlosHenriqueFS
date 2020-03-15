using System;
using System.Collections.Generic;

namespace Senai.MedGroup.WebApi.Domains
{
    public partial class TPaciente
    {
        public TPaciente()
        {
            TConsulta = new HashSet<TConsulta>();
        }

        public int IdPaciente { get; set; }
        public string NomePaciente { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string GeneroP { get; set; }
        public string TelefoneP { get; set; }
        public int? IdUsuario { get; set; }

        public TUsuario IdUsuarioNavigation { get; set; }
        public ICollection<TConsulta> TConsulta { get; set; }
    }
}
