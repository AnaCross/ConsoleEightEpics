using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EightEpicsConsole.Heroes;

namespace EightEpicsConsole
{
    class UI
    {
        public static UI ui = new UI();
        public Adapter adapter;
        private EnumGameLevel level;
        private UI()
        {
            adapter = new Adapter();
        }

        static public UI createUI()
        {
            return ui;
        }

        public void hello()
        {
            Console.Title = "Console Eight Epics";
            //Console.CursorSize = 14;
            Console.WriteLine("Hello Epic Hero! \nWould you like read instruction? [Y/N]: " );
            switch (adapter.readYesNo())
            {
                case "Y":
                    Process.Start("https://www.alderac.com/images/2016/09/EE-rulebook-v1-6.pdf");
                    break;
                case "N":
                    break;
                default:
                    break;
            }
        }

        public EnumGameLevel changeLevel()
        {
            Console.WriteLine("You start adventure with Eight Epics! Change game level: \n(E)asy: 5 Threats and not random Hero\n(M)edium: 5 Threats and random Hero\n(H)ard: 8 Threats and random Hero\nWrite [E/M/H]: ");
            switch (adapter.readLevel())
            {
                case "E":
                    level = EnumGameLevel.EASY;
                    return EnumGameLevel.EASY;
                case "M":
                    level = EnumGameLevel.MEDIUM;
                    return EnumGameLevel.MEDIUM;
                case "H":
                    level = EnumGameLevel.HARD;
                    return EnumGameLevel.HARD;
            }
            return 0;
        }

        public void startRound(Round round)
        {
            Console.Clear();
            Console.WriteLine("Dice pool: ");
            for(int i=0; i<round.dicePool.Count; ++i){
                Console.Write(round.dicePool[i].value + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Threat: " + round.threat.name);
            for(int i=0; i< round.threat.getChallengeList().Count; ++i)
            {
                if(i == round.numberChallange)
                {
                    Console.Write("->");
                }else
                {
                    Console.Write("  ");
                }
                adapter.writeChallenge(round.threat, round.threat.getChallenge(i), i);
            }
            Console.WriteLine();
            Console.WriteLine("Hero:");
            adapter.writeHero(level, round);
            //Console.ReadKey();
        }

        public EnumHeroName changeHero()
        {
            Console.WriteLine("\nChange Hero [A/C/G/J/K/L/O/S]:");
            return adapter.readHero();
        }

        public void actualHero(Round round)
        {
            Console.WriteLine("\nActual Hero: \n{0}\nDo you want reroll dice?[Y/N]:", round.currentHero.name);
            switch (adapter.readYesNo())
            {
                case "Y":
                    rerollDice(round);
                    break;
                case "N":
                    isbreakLivePoint(round);
                    break;
            }
        }

        private void rerollDice(Round round)
        {
            Console.WriteLine("\nChange max 3 dice to reroll. Write number 1 to 6:");
            round.reroll(adapter.readNumber(round));
            showDicePool(round);
            isbreakLivePoint(round);
        }

        private void isbreakLivePoint(Round round)
        {
            Console.WriteLine("\nDo you want break live point?[Y/N]:");
            switch (adapter.readYesNo())
            {
                case "Y":
                    breakLivePoint(round);
                    break;
                case "N":
                    exhaustedHero(round);
                    break;
            }
        }

        private void breakLivePoint(Round round)
        {
            Console.WriteLine("\nYou want use skill or reroll?[S/R]:");
            round.currentHero.breakLivePoint(adapter.readSR(), round);
            exhaustedHero(round);
        }

        private void exhaustedHero(Round round)
        {
            round.exhaustedHero();
            startRound(round);
        }

        public void showDicePool(Round round)
        {
            Console.WriteLine("Dice pool: ");
            for (int i = 0; i < round.dicePool.Count; ++i)
            {
                Console.Write(round.dicePool[i].value + " ");
            }
            Console.WriteLine();
        }
    }
}
