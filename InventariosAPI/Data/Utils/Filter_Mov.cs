using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventariosAPI.Data.Utils
{
    public class Filtro_Mov
    {
        public List<IntegerValue> F_Llave { get; set; }
        public List<IntegerValue> F_OrigenMovs { get; set; }
        public List<ShortValue> F_Almacenes { get; set; }
        public List<CharacterValue> F_Productos { get; set; }

        public Filtro_Mov()
        {
            F_Llave = new List<IntegerValue>();
            F_OrigenMovs = new List<IntegerValue>();
            F_Almacenes = new List<ShortValue>();
            F_Productos = new List<CharacterValue>();
        }
    }
}
