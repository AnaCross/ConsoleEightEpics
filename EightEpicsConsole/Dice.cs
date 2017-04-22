using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class Dice
    {
        int[] wall = {1, 2, 3, 4, 5, 6};
        public int value { get; private set; }
        static Random rnd = new Random();

        public Dice()
        {
            value = wall[rnd.Next(0, 6)];
        }

        public int reroll()
        {
            value = wall[rnd.Next(0, 6)];
            return value;
        }
        public void setValue(int value)
        {
            this.value = value;
        }
    }
}
