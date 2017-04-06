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
        public DicePool(int qua)
        {
            dicePool = new List<Dice>();
            for(int i=0; i<qua; ++i)
            {
                dicePool.Add(new Dice());
            }
        }
    }
}
