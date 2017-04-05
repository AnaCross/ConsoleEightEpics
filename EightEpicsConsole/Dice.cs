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

        public int roll()
        {
            Random rnd = new Random();
            value = rnd.Next(6) + 1;
            return value;
        }
    }
}
