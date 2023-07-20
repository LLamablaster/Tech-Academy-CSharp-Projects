using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    static class Divider
    {
        public static void divide(out int result)
        {
            result = 100;
        }
        
        public static void divide(out int result, int val)
        {
            result = val / 2;
        }
    }
}
