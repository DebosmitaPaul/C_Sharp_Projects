using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp1.Employee;

namespace ConsoleApp1
{
    public class Employee
    {
        public delegate bool ElegibleToPromote(Employee emp);
        public string Name { get; set; }
        public int ID{ get; set; }
        public int Salary{ get; set; }
        public int Experience{ get; set; }

        public static void PromoteEmployee(IList<Employee> employees, ElegibleToPromote IsPromote)
        {
            foreach (Employee emp in employees)
            {
                if(IsPromote(emp))
                {
                    Console.WriteLine("Employee {0} Promoted", emp.Name);
                }
            }
        }
    }
    class UseageOfDelegate
    {
        static void Main_08(string[] args)
        {
            Employee emp1 = new Employee() { ID = 101, Name = "Pranaya", Experience = 5, Salary = 10000};
            Employee emp2 = new Employee(){ ID = 102, Name = "Kumar", Experience = 10, Salary = 20000};
            Employee emp3 = new Employee(){ ID = 103, Name = "Rout", Experience = 20,Salary = 30000};
            IList<Employee> list = new List<Employee>();
            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);
            ElegibleToPromote eg = new ElegibleToPromote(Promote);
            Employee.PromoteEmployee(list, eg);
            //Employee.PromoteEmployee(list, s => s.Experience > 5);
            //Employee.PromoteEmployee(list, x => x.Salary > 10000);
        }
        public static bool Promote(Employee emp)
        {
            return emp.Salary > 10000 ? true : false;
        }
    }
}
