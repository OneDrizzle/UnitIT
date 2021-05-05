using System;
using System.Collections.Generic;
using System.Text;
using UnitITICBM.Models;

namespace UnitITICBM.Persistance
{
    public class EmployeeRepositoryDB
    {
        private List<Employee> employees;

        public EmployeeRepositoryDB()
        {
            employees = new List<Employee>();
        }
    }
}
