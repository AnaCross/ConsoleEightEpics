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
            this.Sort();
        }

        public void SerrinDicePool()
        {
            for (int i=0; i<this.Count; ++i)
            {
                this[i].setValue(6);
            }
        }

        public void rerollDicePool()
        {
            foreach(Dice d in this)
            {
                d.reroll();
                Console.Write(d.value+" ");
            }
            this.Sort();
        }

        public void rerollDicePoll(List<Dice> fewDice)
        {
            int iter = 0;
            foreach(Dice d in this)
            {
                if(d == fewDice[iter])
                {
                    d.reroll();
                    iter++;
                }
            }
            this.Sort();
        }

        private new void Sort()
        {
            bool end = false;
            Dice buf;
            int sum = 0;
            while (end == false)
            {
                sum = 0;
                for (int i = 0; i < this.Count - 1; ++i)
                {
                    if (this[i].value > this[i + 1].value)
                    {
                        buf = this[i];
                        this[i] = this[i + 1];
                        this[i + 1] = buf;
                        sum++;
                    }
                }
                end = sum == 0 ? true : false;
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
