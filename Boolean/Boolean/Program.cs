using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (please enter true or false)");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets have you had?");
            int tickets = Convert.ToInt16(Console.ReadLine());

            if (age > 15 && dui == false && tickets <= 3)
            {
                Console.WriteLine("Congratulations! You qualify for a licensing test.");
            } else {
                Console.WriteLine("Unfortunately you do not qualify for a license at this time."); 
            }
            Console.ReadLine();
        }
    }
}
