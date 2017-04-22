using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole.Heroes
{
    class HeroKhantos : Hero
    {
        public HeroKhantos()
        {
            livePoint = 6;
            name = "Khantos";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.KHANTOS;
        }
        public override void heroSkill()
        {
            //TODO Hero Khantos skill
        }
    }
}
