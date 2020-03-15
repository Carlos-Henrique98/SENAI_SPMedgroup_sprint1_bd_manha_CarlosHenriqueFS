using System;
using System.Collections.Generic;

namespace Senai.MedGroup.WebApi.Domains
{
    public partial class TClinica
    {
        public TClinica()
        {
            TMedico = new HashSet<TMedico>();
        }

        public int IdClinica { get; set; }
        public string NomeClinica { get; set; }
        public string Endereco { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }

        public ICollection<TMedico> TMedico { get; set; }
    }
}
