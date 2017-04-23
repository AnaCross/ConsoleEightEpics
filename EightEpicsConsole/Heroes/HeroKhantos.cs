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
            isExhausted = false;
            descSkill = "Add 1 die to or remove w die from the dice pool.";
        }
        public override void heroSkill()
        {
            //TODO Hero Khantos skill
        }
    }
}
