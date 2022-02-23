using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Adjflete
    {
        public int AdjFleteId { get; set; }
        public string AdjFlete1 { get; set; }
        public int FleteId { get; set; }

        public virtual Flete Flete { get; set; }
    }
}
