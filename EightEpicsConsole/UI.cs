using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class UI
    {
        public static UI ui = new UI();
        private String date;
        private Adapter adapter;
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
            switch (adapter.readYesNo(date))
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
            switch (adapter.readLevel(date))
            {
                case "E":
                    return EnumGameLevel.EASY;
                case "M":
                    return EnumGameLevel.MEDIUM;
                case "H":
                    return EnumGameLevel.HARD;
                default:
                    return EnumGameLevel.EASY;
            }
        }

        public void startRound(Round round)
        {
            Console.Clear();
            Console.WriteLine("Dice pool: ");
            for(int i=0; i<round.dicePool.dicePool.Count; ++i){
                Console.Write(round.dicePool.dicePool[i].value + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Threat: " + round.threat.name);
            for(int i=0; i< round.threat.challengeList.Count; ++i)
            {
                adapter.writeChallenge(round.threat, round.threat.challengeList[i], i);
            }
            Console.WriteLine();
            Console.WriteLine("Hero:");
            Console.ReadKey();
        }
    }
}
