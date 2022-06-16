using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    internal class Company
    {
        public List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void CountEmployees()
        {
            int managerCount = 0, probationerCount = 0, engineerCount = 0;
            foreach (Employee employee in employees)
            {
                switch (employee)
                {
                    case (Manager):
                        managerCount++;
                        break;
                    case (Probationer):
                        probationerCount++;
                        break;
                    case (Engineer):
                        engineerCount++;
                        break;
                }
            }
            Console.WriteLine($"managerCount = {managerCount}, probationerCount = {probationerCount}, engineerCount = {engineerCount}");
        }
    }
}
