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
        public String name;
        public EnumHeroName iD;
        bool isExhausted;
        public int ident;

        public Hero(int lp, String n, EnumHeroName hn, int i)
        {
            livePoint = lp;
            name = n;
            isExhausted = false;
            iD = hn;
            ident = i;
        }

        public void breakLivePoint(String tn)
        {
            switch (tn)
            {
                case "S":
                    break;
                case "R":
                    break;
                case "N":
                    break;
                default:
                    Console.WriteLine("Podałeś niewłaściwą wartość");
                    break;
            }
        }
    
    }
}
