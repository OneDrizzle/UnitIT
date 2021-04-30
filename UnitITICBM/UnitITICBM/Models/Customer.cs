using System;
using System.Collections.Generic;
using System.Text;

namespace UnitITICBM.Models
{
    public class Customer
    {

        public int CustomerID { get; private set; }
        public string CustomerName { get; private set; }

        public Customer(int customerID, string customerName)
        {
            CustomerID = customerID;
            CustomerName = customerName;
        }
        public Customer()
        {

        }

        public void SetID(int id)
        {
            CustomerID = id;
        }

        public void SetName(string name)
        {
            CustomerName = name;
        }
    }
}
