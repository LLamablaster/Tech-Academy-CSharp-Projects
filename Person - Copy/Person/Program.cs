using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee(0, "Sample", "Student");
            Employee test2 = new Employee(1, "Stample", "Spudent");
            test.Quit();
            Console.WriteLine(test == test2);
            Console.ReadLine();
        }
    }
}
