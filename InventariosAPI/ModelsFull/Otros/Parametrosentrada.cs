using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Parametrosentrada
    {
        public int ParametroEntradaId { get; set; }
        public short ParametroId { get; set; }
        public int FleteId { get; set; }
        public string ParametroEntradaValor { get; set; }

        public virtual Flete Flete { get; set; }
        public virtual Parametros Parametro { get; set; }
    }
}
