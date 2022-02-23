using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventariosAPI.Data.Utils
{
    public class CharacterValue
    {
        public string Valor { get; set; }

        public CharacterValue()
        {
            Valor = "Unused";
        }
        public CharacterValue(string CurrentValue)
        {
            Valor = CurrentValue;
        }
    }
}
