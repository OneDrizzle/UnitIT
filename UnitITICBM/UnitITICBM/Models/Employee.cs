using System;
using System.Collections.Generic;
using System.Text;

namespace UnitITICBM.Models
{
    public class Employee
    {

        public int EmployeeID { get; private set; }
        public string EmpFirstName { get; private set; }
        public string EmpLastName { get; private set; }
        public Clearance EmpClearance { get; private set; }

        public Employee(int employeeID, string empFirstName, string empLastName, Clearance empClearance)
        {
            EmployeeID = employeeID;
            EmpFirstName = empFirstName;
            EmpLastName = empLastName;
            EmpClearance = empClearance;
        }
    }
}
