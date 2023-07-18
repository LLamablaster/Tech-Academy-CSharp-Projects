using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParamaters
{
    class Program
    {
        static void Main(string[] args)
        {
            add add = new add();

            Console.WriteLine("Please enter first integer to add.");
            int xx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(OPTIONAL) Please enter second integer to add.");
            string y = Console.ReadLine();
            if (y != "")
            {
                int yy = Convert.ToInt32(y);
                Console.WriteLine("Sum of your numbers is {0}", add.addition(xx, yy));
            } else
            {
                Console.WriteLine("Sum of your numbers is {0}", add.addition(xx));
            }
            

            Console.ReadLine();
        }
    }
}
