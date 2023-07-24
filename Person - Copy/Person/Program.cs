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
            Employee<string> test = new Employee<string>(0, "Sample", "Student");
            Employee<string> test2 = new Employee<string>(1, "Stample", "Spudent");
            Employee<int> test3 = new Employee<int>(2, "Stample", "Spudenti");
            test.SayName();
            test.Quit();
            Console.WriteLine(test == test2);
            Console.ReadLine();
            test.Things.Add("meat");
            test.Things.Add("potatoes");
            test3.Things.Add(1);
            test3.Things.Add(4);
            foreach(string thing in test.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in test3.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

            List<Employee<int>> employees = new List<Employee<int>>();
            for (int i = 0; i<10; i++)
            {
                employees.Add(new Employee<int>(i));
            }
            employees[1].FirstName = "Joe";
            employees[8].FirstName = "Joe";

            List<Employee<int>> joes = new List<Employee<int>>();
            foreach (Employee<int> employee in employees)
            {
                if (employee.FirstName == "Joe") {
                    joes.Add(employee);
                }
            }

            List<Employee<int>> lambdaJoes = employees.Where(x => x.FirstName == "Joe").ToList();
            List<Employee<int>> lambdaHighId= employees.Where(x => x.Id > 5).ToList();
        }
    }
}
