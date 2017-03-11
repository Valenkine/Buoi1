using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi1
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName {get; set;}
        public int DepartmentID {get; set;}
        public int ManagerID {get; set;}
        public double Salary { get; set; }
        
        //Constructor khởi tạo
        public Employee() { }

        public Employee(int ID, string name, int DepID, int MgrID,double salary)
        {
            this.EmployeeID = ID;
            this.EmployeeName = name;
            this.DepartmentID = DepID;
            this.ManagerID = MgrID;
            this.Salary = salary;
        }
    }

    class Manager : Employee
    {
        private int NumberOfEmployee;
        public Manager() { }
        //Constructor khởi tạo
        public Manager(int ID, string name, int DepID,double salary ,int num)
        {
            this.EmployeeID = ID;
            this.EmployeeName = name;
            this.DepartmentID = DepID;
            this.NumberOfEmployee = num;
            this.Salary = salary * 2;
        }

        
    }
}
