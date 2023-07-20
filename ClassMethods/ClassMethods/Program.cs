using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer to divide");
            int val = Convert.ToInt32(Console.ReadLine());
            int result;
            Divider.divide(out result, val);
            Console.WriteLine("Result: about {0}", result);
            Console.ReadLine();

            int test;
            Divider.divide(out test);
            Console.WriteLine("overload test: {0}", test);
            Console.ReadLine();

        }
    }
}
