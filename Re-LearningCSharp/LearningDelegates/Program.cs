using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDelegates
{
    public delegate void HelloFunctionDeleg(string Message);

    class Program
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 101, name = "Mary", salary = 5000, expirience = 5 });
            empList.Add(new Employee() { ID = 102, name = "Mike", salary = 4000, expirience = 4 });
            empList.Add(new Employee() { ID = 103, name = "John", salary = 6000, expirience = 6 });
            empList.Add(new Employee() { ID = 104, name = "Mary", salary = 3000, expirience = 3 });

            //IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(empList, emp => emp.expirience >= 5);

            Console.ReadKey();
        }

        public static bool Promote(Employee emp)
        {
            if(emp.expirience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    delegate bool IsPromotable(Employee empl);

    class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int expirience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.name + " promoted");
                }
            }
        }
    }
}
