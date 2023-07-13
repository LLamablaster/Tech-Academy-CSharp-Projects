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
            barrel.peek();
            Console.WriteLine("How many apples would you like to add to the barrel?");
            barrel.give(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("How many apples would you like to take from the barrel?");
            barrel.take(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("How much piratey rage do you harbor? (as an integer)");
            barrel.chop(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
