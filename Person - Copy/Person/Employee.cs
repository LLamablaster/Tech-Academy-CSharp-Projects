using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Employee : Person, IQuittable
    {
        public Employee(int id = 0, string f = "Jane", string l = "Doe") : base(f,l)
        {
            Id = id;
        }

        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("I quit!");
            Console.ReadLine();
        }

    }
}
