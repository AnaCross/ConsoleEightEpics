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
            isExhausted = false;
            descSkill = "Return 1 exhausted avatar to its ready state, then reroll up to 2 dice.";
        }
        public override void heroSkill(Round round)
        {
            EnumHeroName ehn;
            Console.WriteLine("Change hero to return him [A/C/G/J/K/L/O/S]:");
            foreach (Hero h in round.heroList)
            {
                Console.WriteLine(h.click + h.name);
            }
            ehn = round.ui.adapter.readHero();
            foreach (Hero h in round.heroList)
            {
                if (h.iD == ehn)
                {
                    h.isExhausted = false;
                }
            }
            Console.WriteLine("\nChange max 2 dice to reroll. Write number 1 to 6:");
            round.reroll(round.ui.adapter.readNumber(round));
            round.ui.showDicePool(round);
        }
    }
}
