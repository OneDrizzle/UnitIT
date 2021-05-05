using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using UnitITICBM.Models;

namespace UnitITICBM.Persistance
{
    public class CustomerRepositoryDB : IRepo<Customer>
    {
        private List<Customer> customers;
        public CustomerRepositoryDB()
        {
            customers = new List<Customer>();
        }

        public void Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                Customer customerToFind = new Customer();
                string commandText = $"SELECT Customers.CustomerName FROM Customers WHERE CustomerID = {id}";
                SqlCommand cmd = new SqlCommand(commandText, conn);
                SqlDataReader reader;
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customerToFind.SetID(id);
                        customerToFind.SetName((string)reader[0]);
                    }
                }
                return customerToFind;
            }
        }
        public List<Customer> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                List<Customer> customersToFind = new List<Customer>();
                string commandText = "SELECT * FROM CUSTOMERS";

                SqlCommand cmd = new SqlCommand(commandText, conn);
                SqlDataReader reader;
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customersToFind.Add(new Customer((int)reader[0], (string)reader[1]));
                    }
                }
                return customersToFind;
            }

        }
        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer fromItem, Customer toItem)
        {
            throw new NotImplementedException();
        }
    }
}
