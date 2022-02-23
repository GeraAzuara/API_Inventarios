using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Tipoubicacion
    {
        public Tipoubicacion()
        {
            Ubicacion = new HashSet<Ubicacion>();
        }

        public short TipoUbicaId { get; set; }
        public string TipoUbica { get; set; }
        public string TipoUbicaEstatus { get; set; }

        public virtual ICollection<Ubicacion> Ubicacion { get; set; }
    }
}
