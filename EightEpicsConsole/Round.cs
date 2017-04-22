using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EightEpicsConsole.Heroes;

namespace EightEpicsConsole
{
    class Round
    {
        public Threats threat;
        public DicePool dicePool;
        public List<Hero> heroList;
        public int numberChallange;
        public int countDicePool { get; }

        public Round(Threats th, List<Hero> hL)
        {
            threat = th;
            heroList = hL;
            numberChallange = 0;
            if (threat.iD.Equals(EnumThreatName.SERRIN))
            {
                dicePool.SerrinDicePool();
            }
            else
            {
                createDicePool();
            }
            countDicePool = dicePool.Count;
        }

        void createDicePool()
        {
            dicePool = new DicePool(threat.getChallenge(numberChallange).getQuantityDice());
        }

         
        
    }
}
