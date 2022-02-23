using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            ArbolubicacionitemsUbicacion = new HashSet<Arbolubicacionitems>();
            ArbolubicacionitemsUbicacionPadre = new HashSet<Arbolubicacionitems>();
            InInventario = new HashSet<InInventario>();
            TrasladoDestino = new HashSet<Traslado>();
            TrasladoOrigen = new HashSet<Traslado>();
            Ubicacionadj = new HashSet<Ubicacionadj>();
        }

        public short UbicacionId { get; set; }
        public string Ubicacion1 { get; set; }
        public string UbicacionGeo { get; set; }
        public short UbicacionSuperficie { get; set; }
        public short Cpid { get; set; }
        public short TipoUbicaId { get; set; }
        public short ZonaId { get; set; }

        public virtual Cp Cp { get; set; }
        public virtual Tipoubicacion TipoUbica { get; set; }
        public virtual Zona Zona { get; set; }
        public virtual ICollection<Arbolubicacionitems> ArbolubicacionitemsUbicacion { get; set; }
        public virtual ICollection<Arbolubicacionitems> ArbolubicacionitemsUbicacionPadre { get; set; }
        public virtual ICollection<InInventario> InInventario { get; set; }
        public virtual ICollection<Traslado> TrasladoDestino { get; set; }
        public virtual ICollection<Traslado> TrasladoOrigen { get; set; }
        public virtual ICollection<Ubicacionadj> Ubicacionadj { get; set; }
    }
}
