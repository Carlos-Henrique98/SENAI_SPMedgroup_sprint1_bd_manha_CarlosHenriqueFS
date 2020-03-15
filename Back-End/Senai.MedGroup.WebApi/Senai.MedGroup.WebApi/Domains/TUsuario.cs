using System;
using System.Collections.Generic;

namespace Senai.MedGroup.WebApi.Domains
{
    public partial class TUsuario
    {
        public TUsuario()
        {
            TAdm = new HashSet<TAdm>();
            TMedico = new HashSet<TMedico>();
            TPaciente = new HashSet<TPaciente>();
        }

        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime NascimentoUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }

        public TTipoUsuario IdTipoUsuarioNavigation { get; set; }
        public ICollection<TAdm> TAdm { get; set; }
        public ICollection<TMedico> TMedico { get; set; }
        public ICollection<TPaciente> TPaciente { get; set; }
    }
}
