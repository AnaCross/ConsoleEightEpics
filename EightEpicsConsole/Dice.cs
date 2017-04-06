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
        public int value;
        static Random rnd = new Random();

        public int roll()
        {
            value = wall[rnd.Next(0,6)];
            return value;
        }
    }
}
