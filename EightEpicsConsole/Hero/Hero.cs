using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class Hero
    {   
        int livePoint;
        public String name { get; }
        public String click { get; }
        public EnumHeroName iD { get; }
        bool isExhausted;
        public int ident { get; }

        public Hero(int lp, String n, EnumHeroName hn, int i)
        {
            livePoint = lp;
            name = n;
            click = "[" + name[0] + "]";
            isExhausted = false;
            iD = hn;
            ident = i;
        }

        public void breakLivePoint(String tn)
        {
            switch (tn)
            {
                case "S": //superpower
                    decreaseLivePoint();
                    
                    break;
                case "R": //reroll 3 dice
                    decreaseLivePoint();
                    //TODO reroll() - max 3 dice
                    break;
                case "N": //nothing
                    //TODO nextHero()
                    break;
                default:
                    Console.WriteLine("Wrong value");
                    break;
            }
        }

        void increaseLivePoint()
        {
            livePoint++;
        }

        void decreaseLivePoint()
        {
            livePoint--;
        }
    
    }
}
