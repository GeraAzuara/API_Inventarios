using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Tipotransporte
    {
        public Tipotransporte()
        {
            Camiones = new HashSet<Camiones>();
        }

        public short TipoTransporteId { get; set; }
        public string TipoTransporteNombre { get; set; }

        public virtual ICollection<Camiones> Camiones { get; set; }
    }
}
