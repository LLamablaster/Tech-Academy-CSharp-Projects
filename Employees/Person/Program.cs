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
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                employees.Add(new Employee(i));
            }
            employees[1].FirstName = "Joe";
            employees[8].FirstName = "Joe";

            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            List<Employee> lambdaJoes = employees.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> lambdaHighId = employees.Where(x => x.Id > 5).ToList();
        }
    }
}
