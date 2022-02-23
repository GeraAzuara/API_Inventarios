using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Ubicacionadj
    {
        public short UbicacionId { get; set; }
        public short UbicacionAdjId { get; set; }
        public string UbicacionAdjNombre { get; set; }
        public byte[] UbicacionAdjFile { get; set; }
        public string UbicacionAdjFileGxi { get; set; }

        public virtual Ubicacion Ubicacion { get; set; }
    }
}
