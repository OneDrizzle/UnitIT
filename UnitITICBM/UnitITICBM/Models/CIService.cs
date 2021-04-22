using System;
using System.Collections.Generic;
using System.Text;

namespace UnitITICBM.Models
{
    public class CIService
    {

        public int ServiceID { get; private set; }
        public string ServiceName { get; private set; }
        public string ServiceValue { get; private set; }
        public Employee Employee { get; private set; }

        public CIService(int serviceID, string serviceName, string serviceValue, Employee employee)
        {
            ServiceID = serviceID;
            ServiceName = serviceName;
            ServiceValue = serviceValue;
            Employee = employee;
        }

    }
}
