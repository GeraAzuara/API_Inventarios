using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Origenmov
    {
        public Origenmov()
        {
            InMovimientos = new HashSet<InMovimientos>();
        }

        public int OrigenMovId { get; set; }
        public string OrigenMovNombre { get; set; }
        public string OrigenMovEstatus { get; set; }

        public virtual ICollection<InMovimientos> InMovimientos { get; set; }
    }
}
