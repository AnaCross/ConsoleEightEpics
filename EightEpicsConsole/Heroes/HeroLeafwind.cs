﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole.Heroes
{
    class HeroLeafwind : Hero
    {
        public HeroLeafwind()
        {
            livePoint = 6;
            name = "Leafwind";
            click = "[" + name[0] + "]";
            iD = EnumHeroName.LEAFWIND;
        }
        public override void heroSkill()
        {
            //TODO Hero Leafwinds skill
        }
    }
}
