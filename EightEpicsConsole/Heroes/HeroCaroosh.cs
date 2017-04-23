using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole.Heroes
{
    class HeroCaroosh : Hero
    {
        public HeroCaroosh()
        {
            livePoint = 6;
            name = "Caroosh";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.CAROOSH;
            isExhausted = false;
            descSkill = "Change the result od 1 die to a 1.";
        }
        public override void heroSkill()
        {
            //TODO Hero Caroosh skill
        }
    }
}
