using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class Adapter
    {
        public String readYesNo(String date)
        {
            while (true)
            {
                date = Convert.ToString(Console.ReadLine());
                switch (date)
                {
                    case "Y":
                        return "Y";
                    case "y":
                        return "Y";
                    case "N":
                        return "N";
                    case "n":
                        return "N";
                    default:
                        Console.WriteLine("Breaking date. Write return [Y/N]:");
                        break;

                }
            }
        }

        public String readLevel(String date)
        {
            date = Convert.ToString(Console.ReadLine());
            while (true) {
                switch (date)
                {
                    case "E":
                        return "E";
                    case "e":
                        return "E";
                    case "M":
                        return "M";
                    case "m":
                        return "M";
                    case "H":
                        return "H";
                    case "h":
                        return "H";
                    default:
                        Console.WriteLine("Breaking date. Write return [E/M/H]:");
                        break;
                }
            }
        }

        public void writeChallenge(Threats threat, Challenge ch, int i)
        {
            switch (ch.enumThretChallange)
            {
                case EnumThreatChallenge.LESS:
                    Console.WriteLine("{0}D: {1}-", ch.getQuantityDice(), ch.getValue());
                    break;
                case EnumThreatChallenge.MORE:
                    Console.WriteLine("{0}D: {1}+", ch.getQuantityDice(), ch.getValue());
                    break;
                case EnumThreatChallenge.OTHER:
                    writeOtherChallange(threat, ch, i);
                    break;
                case EnumThreatChallenge.SAME_NUMBER:
                    Console.WriteLine("{0}D: Same number", ch.getQuantityDice());
                    break;
            }
        }

        private void writeOtherChallange(Threats threat, Challenge ch, int i)
        {
            switch (threat.iD)
            {
                case EnumThreatName.MAKANO:
                    Console.WriteLine("{0}D: 1 1 2 3 4 5 6 6", ch.getQuantityDice());
                    break;
                case EnumThreatName.NARSSIS:
                    Console.WriteLine("{0}D: 1 2 3 4 5 6", ch.getQuantityDice());
                    break;
                case EnumThreatName.SERRIN:
                    if (i == 0)
                    {
                        Console.WriteLine("{0}D: 6 6 6 6 6 6 6 6 : 1 1 1 1 1 1 1 1", ch.getQuantityDice());
                    }else
                    {
                        Console.WriteLine("{0}D: 1 1 1 1 1 1 1 1 : 6 6 6 6 6 6 6 6", ch.getQuantityDice());
                    }
                    break;
            }
        }

        public void writeHero(EnumGameLevel egl, List<Hero> hL)
        {
            switch (egl)
            {
                case EnumGameLevel.EASY:
                    for (int i = 0; i < 8; ++i)
                    {
                        Console.WriteLine(hL[i].click + hL[i].name);
                    }
                    break;
                default:
                    for (int i = 0; i < 8; ++i)
                    {
                        Console.WriteLine(hL[i].name);
                    }
                    break;
            }
        }
    }
}
