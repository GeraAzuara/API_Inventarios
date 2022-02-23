using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventariosAPI.Data.Utils
{
    public class IntegerValue
    {
        public int Valor { get; set; }

        public IntegerValue()
        {
            Valor = -500;
        }
        public IntegerValue(int CurrentValue)
        {
            Valor = CurrentValue;
        }
    }
}
