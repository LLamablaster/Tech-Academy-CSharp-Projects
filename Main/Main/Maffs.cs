using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Maffs
    {
        public int maff(int input)
        {
            Console.WriteLine("Multiplying {0} by 5.", input);
            return input * 5;
        }

        public int maff(decimal input)
        {
            Console.WriteLine("Dviding {0} by 2.", input);
            decimal var = Convert.ToDecimal(input);
            return Convert.ToInt32((var / Convert.ToDecimal(2)));
        }

        public int maff(string input)
        {
            Console.WriteLine("Adding {0} to 3.", input);
            int var = Convert.ToInt32(input);
            return var + 3;
        }
    }
}
