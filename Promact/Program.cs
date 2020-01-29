using System;

namespace Promact
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            string deptName;

            Console.WriteLine("Enter Id : ");
            id= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Department Name : ");
            deptName = Console.ReadLine();

            Employee employee1 = new Employee(id, name, deptName);
            HR_Dev employee2 = new HR_Dev();

            
            employee1.GetId();
            employee1.GetName();
            employee1.GetDeptName();

            Console.WriteLine("Designation :");
            string desg = Console.ReadLine();

            Console.WriteLine("Experience :");
            int exp = int.Parse(Console.ReadLine());

            Console.WriteLine( "Basic Salary :");
            int basicSalary = int.Parse(Console.ReadLine());

           employee2.AnnualSalary(desg, exp, basicSalary);

            // employee1.GetDeptName("Mech");
            // employee1.GetDeptName("CS", "Civil");


        }
             
    }
}
