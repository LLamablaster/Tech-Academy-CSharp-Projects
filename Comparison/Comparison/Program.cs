using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1:");
            Console.WriteLine("Enter hourly wage.");
            decimal hourly1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week.");
            int weekly1 = Convert.ToInt16(Console.ReadLine());
            int salary1 = Convert.ToInt32(hourly1 * weekly1 * 52);

            Console.WriteLine("Person 2:");
            Console.WriteLine("Enter hourly wage.");
            decimal hourly2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week.");
            int weekly2 = Convert.ToInt16(Console.ReadLine());
            int salary2 = Convert.ToInt32(hourly2 * weekly2 * 52);

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(Convert.ToString(salary1));
            
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(Convert.ToString(salary2));


            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine(Convert.ToString(salary1 > salary2));
            Console.ReadLine();
        }
    }
}
