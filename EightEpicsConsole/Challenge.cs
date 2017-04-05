using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightEpicsConsole
{
    class Challenge
    {
        public EnumThreatChallenge enumThretChallange;
        public int quantityDice;
        int value;

        public Challenge(EnumThreatChallenge etc)
        {
            enumThretChallange = etc;
            value = 0;
        }

        public int getQuantityDice()
        {
            return quantityDice;
        }

        public void setQuantityDice(int q)
        {
            quantityDice = q;
        }

        public int getValue()
        {
            return value;
        }

        public void setValue(int v)
        {
            value = v;
        }

    }
}
