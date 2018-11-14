using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macro
{
    public class Character
    {
        public int Power { get; set; }
        public int Lives { get; set; }
        public int Inteligence { get; set; }

        public List<Item> items = new List<Item>();

        public Character(int power, int lives, int inteligence)
        {
            this.Power = power;
            this.Lives = lives;
            this.Inteligence = inteligence;
        }
    }
}
