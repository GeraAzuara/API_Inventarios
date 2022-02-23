using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Tipotraslado
    {
        public Tipotraslado()
        {
            Traslado = new HashSet<Traslado>();
        }

        public short TipoTrasladoId { get; set; }
        public string TipoTraslado1 { get; set; }
        public string TipoTrasladoControlInv { get; set; }

        public virtual ICollection<Traslado> Traslado { get; set; }
    }
}
