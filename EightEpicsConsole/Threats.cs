using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class Threats
    {
        public String name;
        int numberChallange;
        int iter;
        public int ident;
        public EnumThreatName iD;
        public List<Challenge> challengeList;

        public Threats(String n, int nc, EnumThreatName etn, int i)
        {
            name = n;
            numberChallange = nc;
            iD = etn;
            challengeList = new List<Challenge>();
            iter = 0;
            ident = i;
        }

        public void setChallengeList(Challenge challenge)
        {
            for(int i=0; i<numberChallange; ++i)
            {
                challengeList.Add(challenge);
            }
        }

        public void setChallengeList(List<Challenge> etnList)
        {
            challengeList = etnList;
        }

        public List<Challenge> getChallengeList()
        {
            return challengeList;
        }

        public void completeChallenge(int var, int quantityChallenge, int quantityDice, Challenge challenge)
        {
            for(int i=0; i<quantityChallenge; ++i)
            {
                challengeList.Add(challenge);
                challengeList.Last().setValue(var);
                //challengeList[i].setValue(var);
                challengeList.Last().setQuantityDice(quantityDice);
            }
        }

        public void completeChallenge(int var, int quantityDice)
        {
            foreach(Challenge ch in challengeList)
            {
                ch.setValue(var);
                ch.setQuantityDice(quantityDice);
            }
        }

    }
}
