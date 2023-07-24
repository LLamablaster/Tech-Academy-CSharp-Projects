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
            IQuittable test = new Employee(0, "Sample", "Student");
            test.Quit();
        }
    }
}
