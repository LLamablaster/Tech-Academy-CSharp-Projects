using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = {"zero", "one", "two", "three"};

            Console.WriteLine("Please enter a string.");
            string input = Console.ReadLine();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] + input;
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();

            int j = 0;
            while (j < 3)
            {
                Console.WriteLine("Trust me, this used to be an infinite loop.");
                j++;
            }
            Console.ReadLine();

            int k = 0;
            while (k < 3)
            {
                Console.WriteLine("< iterates " + k + "times.");
                k++;
            }
            Console.ReadLine();

            int m = 0;
            while (m <= 3)
            {
                Console.WriteLine("<= iterates " + m + "times.");
                m++;
            }
            Console.ReadLine();

            var strings = new List<string> { "these", "are", "strings" };
            Console.WriteLine("Enter search term.");
            string term = Console.ReadLine();
            bool found = false;
            for (int n = 0; n < strings.Count; n++)
            {
                if (strings[n] == term)
                {
                    Console.WriteLine("Term present at list index " + n);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Term not found.");
            }
            Console.ReadLine();

            var strings2 = new List<string> { "these", "are", "more", "strings", "more", "these" };
            Console.WriteLine("Enter search term.");
            string term2 = Console.ReadLine();
            bool found2 = false;
            for (int o = 0; o < strings2.Count; o++)
            {
                if (strings2[o] == term2)
                {
                    Console.WriteLine("Term present at list index " + o);
                    found2 = true;
                }
            }
            if (!found2)
            {
                Console.WriteLine("Term not found.");
            }
            Console.ReadLine();

            var strings3 = new List<string> { "these", "are", "more", "strings", "more", "these" };
            var tracker = new List<string> { };
            foreach (string p in strings3)
            {
                tracker.Add(p);
                int count = tracker.Count(z => z == p);
                Console.WriteLine(p + ": total occurrences = " + count);
            }
            
            Console.ReadLine();

        }
    }
}
