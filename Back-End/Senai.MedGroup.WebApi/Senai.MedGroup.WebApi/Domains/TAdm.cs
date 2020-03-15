using System;
using System.Collections.Generic;

namespace Senai.MedGroup.WebApi.Domains
{
    public partial class TAdm
    {
        public int IdAdm { get; set; }
        public int? IdUsuario { get; set; }

        public TUsuario IdUsuarioNavigation { get; set; }
    }
}
