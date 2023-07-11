using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x<4) {
                x++;
                Console.WriteLine("While Iteration " + x);
                if (x%2 == 0)
                {
                    Console.WriteLine("This iteration is even.");
                } 
            }

            int y = 0;
            do
            {
                y++;
                Console.WriteLine("Do While Iteration " + y);
                if (y % 2 == 0)
                {
                    Console.WriteLine("This iteration is even.");
                }
            }
            while (y < 4);

            Console.ReadLine();
        }
    }
}
