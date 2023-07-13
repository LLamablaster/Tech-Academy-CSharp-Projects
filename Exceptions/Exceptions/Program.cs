using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 10, 20, 30, 40, 50 };
            try
            {
                Console.WriteLine("please enter a number to divide by");
                double div = Convert.ToDouble(Console.ReadLine());
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine(numbers[i] + " divided by " + div + " is " + numbers[i] / div);
                }
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number comprised of digits.");
                Console.ReadLine();

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please enter a nonzero number.");
                Console.ReadLine();

            }
        }
    }
}
