using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Pitcher pitcher = new Pitcher();
            pitcher.pour(1, 2);

            pitcher.pour(y:2, x:1);
        }
    }
}
