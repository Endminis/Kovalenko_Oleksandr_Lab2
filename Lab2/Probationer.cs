using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
     class Probationer : Employee
    {
        public Probationer(int age, string name, int salary) : base(age, name, salary)
        {
            Console.WriteLine($"\nNew probationer was hired:\n    Name: {name}\n    Age: {age}\n    Salary: {salary}\n");
        }
    }
}
