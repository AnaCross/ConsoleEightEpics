using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class UI
    {
        public static UI ui = new UI();
        private String date;
        private UI() { }

        static public UI createUI()
        {
            return ui;
        }

        public void hello()
        {
            Console.Title = "Console Eight Epics";
            //Console.CursorSize = 14;
            Console.WriteLine("Hello Epic Hero! \nWould you like read instruction? [Y/N]: " );
            switch (readYesNo())
            {
                case "Y":
                    break;
                case "N":
                    break;
                default:
                    break;
            }

            
            
        }

        private String readYesNo()
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

        public EnumGameLevel changeLevel()
        {
            Console.WriteLine();
            return 0;
        }
    }
}
