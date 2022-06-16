﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
     class Engineer : Employee
    {
        public Engineer(int age, string name, int salary, Company company) : base(age, name, salary, company)
        {
            Console.WriteLine($"\nNew engineer was hired:\n    Name: {name}\n    Age: {age}\n   Salary: {salary}\n");
        }
    }
}
