using System;
using System.Collections.Generic;

namespace InventariosAPI.Models
{
    public partial class Cp
    {
        public Cp()
        {
            Ubicacion = new HashSet<Ubicacion>();
        }

        public short Cpid { get; set; }
        public string Cpasentamiento { get; set; }
        public string CptipoAsentamiento { get; set; }
        public string Cpmunicipio { get; set; }
        public string Cpentidad { get; set; }
        public string Cpciudad { get; set; }
        public string Cpadmon { get; set; }
        public string Cpzona { get; set; }
        public string Cp1 { get; set; }

        public virtual ICollection<Ubicacion> Ubicacion { get; set; }
    }
}
