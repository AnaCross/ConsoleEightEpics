using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class DicePool : List<Dice>
    {
        //public List<Dice> dicePool;
        public DicePool(int qua)
        {
            //dicePool = new List<Dice>();
            for(int i=0; i<qua; ++i)
            {
                Add(new Dice());
            }
        }

        public void SerrinDicePool()
        {
            for (int i=0; i<this.Count; ++i)
            {
                this[i].setValue(6);
            }
        }

        /*
        public Dice getDice(int i)
        {
            return this[i];
        }
        */
    }
}
