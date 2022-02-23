using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Camiones
    {
        public Camiones()
        {
            Flete = new HashSet<Flete>();
        }

        public short CamionId { get; set; }
        public string CamionDescripcion { get; set; }
        public string CamionPlacas { get; set; }
        public string CamionEconomico { get; set; }
        public short CamionCapacidad { get; set; }
        public string CamionEstatus { get; set; }
        public short TipoTransporteId { get; set; }
        public short TransportistaId { get; set; }

        public virtual Tipotransporte TipoTransporte { get; set; }
        public virtual Transportista Transportista { get; set; }
        public virtual ICollection<Flete> Flete { get; set; }
    }
}
