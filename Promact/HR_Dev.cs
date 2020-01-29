using System;
using System.Collections.Generic;
using System.Text;

namespace Promact
{
    public class HR_Dev
    {
        private string designation;
        private int exp;
        public string GetDesignation()
        {
             return Designation;
        }
        public int GetExperience()
        {
            return Exp;
        }
        public string Designation
        {
            get
            {
                return designation;
            }
            set
            {
                designation = value;
            }
        }
        public int Exp
        {
            get
            {
                return exp;
            }
            set
            {
                exp = value;
            }
        }


        int temp;
        public void AnnualSalary(string desg, int exp, int basicSalary)
        {

            if (desg == "HR")
            {
                temp = 12*(basicSalary + (1000 * exp));
            }
            else if (desg == "Developer")
            {
                temp = 12*(basicSalary + (2000 * exp));
            }
            Console.WriteLine($"Annual Salary is : {temp}");
        }
    }
}