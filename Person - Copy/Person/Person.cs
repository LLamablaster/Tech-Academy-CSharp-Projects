using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public abstract class Person
    {
        public Person(string f = "Jane", string l = "Doe")
        {
            FirstName = f;
            LastName = l;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        abstract public void SayName();
    }
}
