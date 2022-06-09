using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
     class Employee
    {
        public int EmployeeAge { get; set; }
        public int EmployeeSalary { get; set; } 
        public string EmployeeName { get; set; }
        public bool isFired { get; set; }

        public Employee()
        {
            this.EmployeeAge = 0;
            this.EmployeeSalary = 0;
            this.EmployeeName = "Undefined";
            this.isFired = false;
        }
        public Employee(int age, string name, int salary)
        {
            this.EmployeeAge = age;
            this.EmployeeName = name;
            this.EmployeeSalary = salary;
            this.isFired = false;
        }

        public void DisplayEmployeeData()
        {
            Console.WriteLine("\nDisplaying employee's data...");
            Console.WriteLine("Employee's name is: " + EmployeeName);
            Console.WriteLine("Employee's age is: " + EmployeeAge);
            Console.WriteLine("Employee's salary is: " + EmployeeSalary);
            Console.WriteLine("Is employee fired: " + isFired);
        }
        public void IncreaseSalary(int increase)
        {
            EmployeeSalary += increase;
            Console.WriteLine($"Increasing salary...\nOld salary: {EmployeeSalary - increase}, new salary: {EmployeeSalary}");
        }
        public void FireEmployee(object? obj)
        {
            Console.WriteLine($"\nFiring {this.EmployeeName}...");
            this.EmployeeSalary = 0;
            this.isFired = true;
        }
        public override bool Equals(object? obj)
        {
            if ((obj == null) && !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            Employee tmp = (Employee)obj;
            return EmployeeAge == tmp.EmployeeAge && EmployeeName == tmp.EmployeeName && EmployeeSalary == tmp.EmployeeSalary;
        }
        public override int GetHashCode()
        {
            return EmployeeAge.GetHashCode() + EmployeeName.GetHashCode() + EmployeeSalary.GetHashCode();
        }
        public override string ToString()
        {
             return "Employee: " + EmployeeAge.ToString() + " " + EmployeeName.ToString() + " " + EmployeeSalary.ToString();
        }
    }

}
