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
        }
        public override void heroSkill()
        {
            //TODO Hero Sylliph skill
        }
    }
}
