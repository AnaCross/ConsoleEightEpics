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
            isExhausted = false;
            descSkill = "Restore 1 life point to another avatar, then reroll up to 2 dice.";
        }
        public override void heroSkill()
        {
            //TODO Hero Auriel skill
        }
    }
}
