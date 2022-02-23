using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Negocios
    {
        public Negocios()
        {
            Almacenes = new HashSet<Almacenes>();
        }

        public short NegocioId { get; set; }
        public string NegocioNombre { get; set; }
        public string NegocioEstatus { get; set; }
        public short EmpresaId { get; set; }

        public virtual Empresas Empresa { get; set; }
        public virtual ICollection<Almacenes> Almacenes { get; set; }
    }
}
