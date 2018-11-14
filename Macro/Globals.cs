using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macro
{
    public class Globals
    {
        public Character Character { get; set; }

        public Globals(Character character)
        {
            this.Character = character;
        }
    }
}
