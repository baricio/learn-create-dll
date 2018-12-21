using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldDomination
{
    public class Operation
    {
        public static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        public static int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        public static double Division(int value1, int value2)
        {
            if (value2 == 0)
            {
                return 0;
            }
            return value1 / value2;
        }

        public static int Multi(int value1, int value2)
        {
            return value1 * value2;
        }
    }
}
