using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Barrel
    {
        public Barrel()
        {
            Random random = new Random();
            apples = random.Next(1, 20);
        }

        public int apples { get; set; }

        public void peek()
        {
            Console.WriteLine("The barrel contains " + apples + " apples.");
            Console.ReadLine();
        }

        public void give(int num)
        {
            apples += num;
            Console.WriteLine("You add " + num + " apples to the barrel.");
            peek();
        }

        public void take(int num)
        {
            if (num > apples)
            {
                apples = 0;
                Console.WriteLine("You take all the apples from the barrel.");
                peek();
            }
            else
            {
                apples -= num;
                Console.WriteLine("You take " + num + " apples from the barrel.");
                peek();
            }
        }

        public void chop(int num)
        {
            Console.WriteLine("You chop the barrel into " + num + " pieces using your trusty cutlass!");
            if (apples > 0)
            {
                int spill = apples % num;
                int piece = apples / num;
                Console.WriteLine(spill + " apples roll onto the floor.");
                Console.WriteLine(piece + " apples fall neatly into each of the " + num + " barrel sections.");
            }
            else
            {
                Console.WriteLine("The barrel was empty.");
            }
            Console.ReadLine();

        }
    }
}
