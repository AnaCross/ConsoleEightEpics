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
                        return "m";
                    case "H":
                        return "H";
                    case "h":
                        return "h";
                    default:
                        Console.WriteLine("Breaking date. Write return [E/M/H]:");
                        break;
                }
            }
        }
    }
}
