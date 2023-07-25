using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datetime = DateTime.Now;
            Console.WriteLine("It is currently {0}.", datetime);
            Console.WriteLine("How many hours would you like to peek ahead?");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime future = datetime.AddHours(hours);
            Console.WriteLine("It will be {0}.", future);
            Console.ReadLine();

        }
    }
}
