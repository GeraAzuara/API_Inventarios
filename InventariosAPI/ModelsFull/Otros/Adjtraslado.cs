using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Adjtraslado
    {
        public int AdjTrasladoId { get; set; }
        public string AdjTraslado1 { get; set; }
        public int TrasladoId { get; set; }

        public virtual Traslado Traslado { get; set; }
    }
}
