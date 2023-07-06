using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the weight of your package in pounds.");
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.WriteLine("Have a nice day.");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Please enter the width of your package in inches.");
                double packageWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the height of your package in inches.");
                double packageHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the length of your package in inches.");
                double packageLength = Convert.ToDouble(Console.ReadLine());

                if ((packageWidth + packageLength + packageHeight) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.WriteLine("Have a nice day.");
                    Console.ReadLine();
                } else
                {
                    double quote = (packageHeight * packageLength * packageWidth * packageWeight) / 100;
                    Console.WriteLine("Your package will cost $" + quote + " to ship.");
                    Console.ReadLine();
                }
            }

        }
    }
}
