using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
     class Engineer : Employee
    {
        public Engineer(int age, string name, int salary) : base(age, name, salary)
        {
            Console.WriteLine($"\nNew engineer was hired:\n    Name: {name}\n    Age: {age}\n   Salary: {salary}\n");
        }
    }
}
