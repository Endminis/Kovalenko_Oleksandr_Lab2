using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
     class Manager:Employee
    {
        public Manager(int age, string name, int salary, Company company):base(age, name, salary, company)
        {
            Console.WriteLine($"\nNew manager was hired:\n    Name: {name}\n    Age: {age}\n    Salary: {salary}\n");
        }
    }
}
