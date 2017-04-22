using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole.Heroes
{
    class HeroJarroth : Hero
    {
        public HeroJarroth()
        {
            livePoint = 5;
            name = "Jarroth";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.JAROTH;
        }
        public override void heroSkill()
        {
            //TODO Hero Jarroth skill
        }
    }
}
