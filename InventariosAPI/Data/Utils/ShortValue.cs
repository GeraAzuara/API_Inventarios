using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventariosAPI.Data.Utils
{
    public class ShortValue
    {
        public short Valor { get; set; }

        public ShortValue()
        {
            Valor = -500;
        }
        public ShortValue(short CurrentValue)
        {
            Valor = CurrentValue;
        }
    }
}
