using System;
using System.Collections.Generic;
using System.Text;

namespace Promact
{
    public class Employee : HR_Dev
    {
        private int id;
        private string name;
        private string deptName;

        public Employee(int id_ex, string name_ex, string deptName_ex)
        {
            Id = id_ex;
            Name = name_ex;
            DeptName = deptName_ex;
        }
        public void GetId()
        {
            MethodCalledEvent("GetId() method called");
            Console.WriteLine(Id);
        }

        public void GetName()
        {
            MethodCalledEvent("GetName() method called");
            Console.WriteLine(Name);
        }

        public void GetDeptName()
        {
            MethodCalledEvent("GetDeptName() method called");
            Console.WriteLine(DeptName);
        }

        public void GetDeptName(string dept)
        {
            //MethodCalledEvent("GetDeptName() method called");
            deptName = dept;
            Console.WriteLine(DeptName);
        }

        public void GetDeptName(string existingDept, string newDept)
        {
            //MethodCalledEvent("GetDeptName() method called");
            //if (existingDept != newDept)
            //{
            //    deptName = newDept;
            //}
            Console.WriteLine(DeptName);
        }

        public event MethodCalledDelegate MethodCalled;

        public void MethodCalledEvent(string msg)
        {
            Console.WriteLine(msg);
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string DeptName
        {
            get
            {
                return deptName;
            }
            set
            {
                deptName = value;
            }
        }
 
            

    }
}
