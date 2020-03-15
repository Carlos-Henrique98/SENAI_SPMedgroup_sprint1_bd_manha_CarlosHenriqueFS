using System;
using System.Collections.Generic;

namespace Senai.MedGroup.WebApi.Domains
{
    public partial class TSituacao
    {
        public TSituacao()
        {
            TConsulta = new HashSet<TConsulta>();
        }

        public int IdSituacao { get; set; }
        public string Situacao { get; set; }

        public ICollection<TConsulta> TConsulta { get; set; }
    }
}
