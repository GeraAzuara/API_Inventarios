using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Arbolubicacion
    {
        public Arbolubicacion()
        {
            Arbolubicacionitems = new HashSet<Arbolubicacionitems>();
        }

        public short ArbolUbicacionId { get; set; }
        public string ArbolUbicacionNombre { get; set; }
        public string ArbolUbicacionDescripcion { get; set; }
        public string ArbolUbicacionEstatus { get; set; }

        public virtual ICollection<Arbolubicacionitems> Arbolubicacionitems { get; set; }
    }
}
