using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole.Heroes
{
    class HeroOphinia : Hero
    {
        public HeroOphinia()
        {
            livePoint = 4;
            name = "Ophinia";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.OPHINIA;
            isExhausted = false;
            descSkill = "Use the power of another avatar (ready or exhausted)";
        }
        public override void heroSkill()
        {
            //TODO Hero Ophinia skill
        }
    }
}
