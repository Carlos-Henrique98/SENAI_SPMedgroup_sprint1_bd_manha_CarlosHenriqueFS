using System;
using System.Collections.Generic;

namespace Senai.MedGroup.WebApi.Domains
{
    public partial class TTipoUsuario
    {
        public TTipoUsuario()
        {
            TUsuario = new HashSet<TUsuario>();
        }

        public int IdTipoUsuario { get; set; }
        public string TipoUsuario { get; set; }

        public ICollection<TUsuario> TUsuario { get; set; }
    }
}
