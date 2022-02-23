using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Operadores
    {
        public Operadores()
        {
            Flete = new HashSet<Flete>();
        }

        public short OperadorId { get; set; }
        public string OperadorNombre { get; set; }
        public string OperadorApellidos { get; set; }
        public string OperadorEstatus { get; set; }
        public string OperadorTag { get; set; }
        public short TransportistaId { get; set; }

        public virtual Transportista Transportista { get; set; }
        public virtual ICollection<Flete> Flete { get; set; }
    }
}
