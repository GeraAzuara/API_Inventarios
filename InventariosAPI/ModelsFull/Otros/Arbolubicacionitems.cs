using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Arbolubicacionitems
    {
        public int ArbolUbicacionItemId { get; set; }
        public short UbicacionId { get; set; }
        public short UbicacionPadreId { get; set; }
        public short ArbolUbicacionId { get; set; }

        public virtual Arbolubicacion ArbolUbicacion { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }
        public virtual Ubicacion UbicacionPadre { get; set; }
    }
}
