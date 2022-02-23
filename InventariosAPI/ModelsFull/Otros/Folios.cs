using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Folios
    {
        public Folios()
        {
            Flete = new HashSet<Flete>();
            Foliosparametros = new HashSet<Foliosparametros>();
        }

        public short FolioId { get; set; }
        public string FolioSerie { get; set; }
        public int FolioValor { get; set; }
        public string Folio { get; set; }

        public virtual ICollection<Flete> Flete { get; set; }
        public virtual ICollection<Foliosparametros> Foliosparametros { get; set; }
    }
}
