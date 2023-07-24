using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Employee<T> : Person, IQuittable
    {
        public Employee(int id = 0, string f = "Jane", string l = "Doe") : base(f,l)
        {
            Id = id;
            Things = new List<T>();
        }

        public int Id { get; set; }
        public List<T> Things { get; set; }

        public void Quit()
        {
            Console.WriteLine("I quit!");
            Console.ReadLine();
        }
        override public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            Console.ReadLine();
        }

        public static bool operator== (Employee<T> first, Employee<T> second)
        {
            if (first.Id == second.Id) { return true; } else { return false; }

        }

        public static bool operator !=(Employee<T> first, Employee<T> second)
        {
            if (first.Id != second.Id) { return true; } else {return false; }
            
        }

    }
}
