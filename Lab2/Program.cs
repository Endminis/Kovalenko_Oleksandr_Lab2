namespace Lab2_1
{ 
    class Program
    {
        static void Main()
        {
            Company company = new Company();
            Probationer probationer1 = new Probationer(43, "Bob", 500, company);
          //  probationer1.DisplayEmployeeData();

            Manager manager1 = new Manager(66, "Kate", 2000, company);
            manager1.IncreaseSalary(400);
          //  manager1.DisplayEmployeeData();

            Engineer engineer1 = new Engineer(34, "Tom", 1500, company);
            //  engineer1.DisplayEmployeeData();

            company.CountEmployees();

            engineer1.FireEmployee(engineer1, company);
         //   engineer1.DisplayEmployeeData();

            company.CountEmployees();

/*            if (probationer1.Equals(manager1))
            {
                Console.WriteLine("\nHashCode is equal");
            }
            else
            {
                Console.WriteLine("\nHashCode is different");
            }

            Console.WriteLine(probationer1.GetHashCode());
            Console.WriteLine(manager1.GetHashCode() + "\n");

            Console.WriteLine(manager1.ToString() + "\n");
            Console.WriteLine(engineer1.ToString());
*/
        }

    }
}
