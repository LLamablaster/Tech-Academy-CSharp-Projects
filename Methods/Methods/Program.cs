using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Barrel barrel = new Barrel();
            lookInBarrel(barrel);

            Console.WriteLine("How many apples would you like to add to the barrel?");
            barrel.give(Convert.ToInt32(Console.ReadLine()));
            lookInBarrel(barrel);

            Console.WriteLine("How many apples would you like to take from the barrel?");
            barrel.take(Convert.ToInt32(Console.ReadLine()));
            lookInBarrel(barrel);

            Console.WriteLine("How much piratey rage do you harbor? (as an integer)");
            Console.WriteLine("You resolved {0} rage!", barrel.chop(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();

        }

        static void lookInBarrel(Barrel barrel)
        {
            Console.WriteLine("The barrel contains {0} apples.", barrel.peek());
            Console.ReadLine();
        }
    }
}
