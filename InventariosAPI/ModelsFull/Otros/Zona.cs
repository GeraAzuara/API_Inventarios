using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Zona
    {
        public Zona()
        {
            Ubicacion = new HashSet<Ubicacion>();
        }

        public short ZonaId { get; set; }
        public string Zona1 { get; set; }
        public string ZonaEstatus { get; set; }

        public virtual ICollection<Ubicacion> Ubicacion { get; set; }
    }
}
