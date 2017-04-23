using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole.Heroes
{
    class HeroGron : Hero
    {
        public HeroGron()
        {
            livePoint = 6;
            name = "Gron";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.GRON;
            isExhausted = false;
            descSkill = "Change the result of 1 die to a 6";
        }
        public override void heroSkill()
        {
            //TODO Hero Gron skill
        }
    }
}
