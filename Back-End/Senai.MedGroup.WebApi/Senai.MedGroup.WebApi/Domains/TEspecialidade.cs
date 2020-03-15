using System;
using System.Collections.Generic;

namespace Senai.MedGroup.WebApi.Domains
{
    public partial class TEspecialidade
    {
        public TEspecialidade()
        {
            TMedico = new HashSet<TMedico>();
        }

        public int IdEspecialidade { get; set; }
        public string NomeEspecialidade { get; set; }

        public ICollection<TMedico> TMedico { get; set; }
    }
}
