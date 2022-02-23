using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Almacenes
    {
        public Almacenes()
        {
            InInventario = new HashSet<InInventario>();
            InMovimientos = new HashSet<InMovimientos>();
        }

        public short AlmacenId { get; set; }
        public string AlmacenNombre { get; set; }
        public string AlmacenTag { get; set; }
        public string AlmacenEstatus { get; set; }
        public short NegocioId { get; set; }

        public virtual Negocios Negocio { get; set; }
        public virtual ICollection<InInventario> InInventario { get; set; }
        public virtual ICollection<InMovimientos> InMovimientos { get; set; }
    }
}
