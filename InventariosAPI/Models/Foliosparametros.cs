using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Foliosparametros
    {
        public short FolioParametroId { get; set; }
        public short FolioId { get; set; }
        public short ParametroId { get; set; }

        public virtual Folios Folio { get; set; }
        public virtual Parametros Parametro { get; set; }
    }
}
