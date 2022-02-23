using System;
using System.Collections.Generic;

namespace InventariosAPI.ModelsFull
{
    public partial class Parametros
    {
        public Parametros()
        {
            Foliosparametros = new HashSet<Foliosparametros>();
            Parametrosentrada = new HashSet<Parametrosentrada>();
        }

        public short ParametroId { get; set; }
        public string ParametroNombre { get; set; }
        public string ParametroLista { get; set; }
        public string ParametroQry { get; set; }

        public virtual ICollection<Foliosparametros> Foliosparametros { get; set; }
        public virtual ICollection<Parametrosentrada> Parametrosentrada { get; set; }
    }
}
