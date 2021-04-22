using System;
using System.Collections.Generic;
using System.Text;
using UnitITICBM.Models;

namespace UnitITICBM.Persistance
{
    public class CustomerRepositoryDB
    {
        private List<Customer> customers;
        public CustomerRepositoryDB()
        {
            customers = new List<Customer>();
        }
    }
}
