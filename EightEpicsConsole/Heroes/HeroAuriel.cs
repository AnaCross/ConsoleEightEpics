using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole.Heroes
{
    class HeroAuriel : Hero
    {
        public HeroAuriel()
        {
            livePoint = 5;
            name = "Auriel";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.AURIEL;
        }
        public override void heroSkill()
        {
            //TODO Hero Auriel skill
        }
    }
}
