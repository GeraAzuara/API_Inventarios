using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Empresas
    {
        public Empresas()
        {
            Flete = new HashSet<Flete>();
            Negocios = new HashSet<Negocios>();
        }

        public short EmpresaId { get; set; }
        public string Empresa { get; set; }

        public virtual ICollection<Flete> Flete { get; set; }
        public virtual ICollection<Negocios> Negocios { get; set; }
    }
}
