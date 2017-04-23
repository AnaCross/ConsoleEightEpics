using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole.Heroes
{
    class HeroSylliph : Hero
    {
        public HeroSylliph()
        {
            livePoint = 5;
            name = "Sylliph";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.SYLLIPH;
            isExhausted = false;
            descSkill = "Choose the result of a die. Increase or decrease by 1 all dice showing that result.";
        }
        public override void heroSkill()
        {
            //TODO Hero Sylliph skill
        }
    }
}
