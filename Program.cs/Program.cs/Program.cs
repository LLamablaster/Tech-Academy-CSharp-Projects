using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("Hello, " + yourName +". What course are you in?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number? (Please enter numerals)");
            int yourPage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? (Please enter 'true' or 'false')");
            bool yourHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourPositives = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int yourStudyTime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers.");
            Console.WriteLine("An Instructor will respond to this shortly.");
            Console.WriteLine("Have a great day!");

            Console.ReadLine();
        }
    }
}
