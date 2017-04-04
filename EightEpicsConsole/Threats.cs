using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class Threats
    {
        String name;
        int numberChallange;
        EnumThreatName enumThreatName;
        List<Challenge> challengeList;

        public Threats(String n, int nc, EnumThreatName etn)
        {
            name = n;
            numberChallange = nc;
            enumThreatName = etn;
            challengeList = new List<Challenge>();
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

    }
}
