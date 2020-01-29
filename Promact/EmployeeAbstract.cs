using System;
using System.Collections.Generic;
using System.Text;

namespace Promact
{
    public abstract class EmployeeAbstract
    {
        public abstract void GetId();
        public abstract void GetName();
        public abstract void GetDesignation();
        public abstract void AnnualSalary(string desg, int exp, int basicSalary);
    }
}
