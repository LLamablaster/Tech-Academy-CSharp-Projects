using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week.");
            try
            {
                DaysOfWeek input = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());
                Console.WriteLine(input);
                Console.ReadLine();
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week. (capitalization matters!)");
                Console.ReadLine();

            }





        }



        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
