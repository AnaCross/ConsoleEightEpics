﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole.Heroes
{
    abstract class Hero
    {   
        public int livePoint { get; set; } //aut
        public String name { get; set; } //aut
        public String click { get; set; } //aut
        public EnumHeroName iD { get; set; } //aut
        public bool isExhausted { get; set; }
        public String descSkill { get; set; }
        public static int ident = 0;

        public Hero()
        {
        /*
            livePoint = lp; //aut
            name = n; //aut
            click = "[" + name[0] + "]"; //aut
            isExhausted = false;
            iD = hn; //aut
            */
            ident++; 
        }

        public void breakLivePoint(String tn)
        {
            switch (tn)
            {
                case "S": //superpower
                    decreaseLivePoint();
                    heroSkill();
                    break;
                case "R": //reroll 3 dice
                    decreaseLivePoint();
                    //TODO reroll() - max 3 dice
                    break;
                case "N": //nothing
                    //TODO nextHero()
                    break;
                default:
                    Console.WriteLine("Wrong value");
                    break;
            }
        }

        void increaseLivePoint()
        {
            livePoint++;
        }

        void decreaseLivePoint()
        {
            livePoint--;
        }
        abstract public void heroSkill();
        //TODO All hero skills
    }
}
