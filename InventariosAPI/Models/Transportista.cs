using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Transportista
    {
        public Transportista()
        {
            Camiones = new HashSet<Camiones>();
            Operadores = new HashSet<Operadores>();
        }

        public short TransportistaId { get; set; }
        public string TransportistaNombre { get; set; }
        public string TransportistaEstatus { get; set; }
        public string TransportistaTag { get; set; }

        public virtual ICollection<Camiones> Camiones { get; set; }
        public virtual ICollection<Operadores> Operadores { get; set; }
    }
}
