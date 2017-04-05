using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class DicePool
    {
        public List<Dice> dicePool;
        Dice dice;
        public DicePool(int qua)
        {
            for(int i=0; i<qua; ++i)
            {
                dice = new Dice();
                dicePool.Add(dice);
            }
        }
    }
}
