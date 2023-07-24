using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Employee : Person
    {
        public Employee(int id = 0, string f = "Jane", string l = "Doe") : base(f,l)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
