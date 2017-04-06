using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class Round
    {
        public Threats threat;
        public DicePool dicePool;
        List<Hero> heroList;
        int numberChallange;

        public Round(Threats th, List<Hero> hL)
        {
            threat = th;
            heroList = hL;
            numberChallange = 0;
            if (threat.iD.Equals(EnumThreatName.SERRIN))
            {
                foreach (Dice i in dicePool.dicePool)
                {
                    i.value = 6;
                }
            }
            else
            {
                createDicePool();
            }
        }

        void createDicePool()
        {
            dicePool = new DicePool(threat.challengeList[numberChallange].getQuantityDice());
            foreach(Dice i in dicePool.dicePool)
            {
                i.roll();
            }
        }
        
    }
}
