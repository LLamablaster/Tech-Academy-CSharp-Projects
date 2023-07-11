using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[]  text = { "zero", "one", "two", "three" };
            int[] numbers = { 101010, 10, 200, 3000, 40000, 500000 };
            List<string> list = new List<string>();
            list.Add("badger");
            list.Add("walrus");
            list.Add("giraffe");
            list.Add("grandpa");

            Console.WriteLine("Select a number between zero and 3.");
            string textselection1 = Console.ReadLine();
            int selection1 = Convert.ToInt16(textselection1);
            if (0 <= selection1 && selection1 <= 3)
            {
                Console.WriteLine("You selected the index of " + text[selection1]);
            } else 
            {
                Console.WriteLine("You selected an out-of-bounds index.");
            }
            Console.ReadLine();

            Console.WriteLine("Select a number between zero and 5.");
            string textselection2 = Console.ReadLine();
            int selection2 = Convert.ToInt16(textselection2);
            if (0 <= selection2 && selection2 <= 5)
            {
                Console.WriteLine("You selected the index of " + numbers[selection2]);
            }
            else
            {
                Console.WriteLine("You selected an out-of-bounds index.");
            }
            Console.ReadLine();

            Console.WriteLine("Select a number between zero and 3.");
            string textselection3 = Console.ReadLine();
            int selection3 = Convert.ToInt16(textselection3);
            if (0 <= selection3 && selection3 <= 3)
            {
                Console.WriteLine("You selected the index of " + list[selection3]);
            }
            else
            {
                Console.WriteLine("You selected an out-of-bounds index.");
            }
            Console.ReadLine();
        }
    }
}
