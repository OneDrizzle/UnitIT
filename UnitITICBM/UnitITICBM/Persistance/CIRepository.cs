using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using UnitITICBM.Models;

namespace UnitITICBM.Persistance
{
    public class CIRepository
    {
        public List<CI> cIs;
        public AttributeRepositoryDB attributes;
        public CustomerRepositoryDB customers;
        public TypeRepositoryDB types;

        public CIRepository(AttributeRepositoryDB attributesRepo, CustomerRepositoryDB customerRepo, TypeRepositoryDB typeRepo)
        {
            cIs = new List<CI>();
            attributes = attributesRepo;
            customers = customerRepo;
            types = typeRepo;
        }

        public void Add(CI item)
        {
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CI GetFromCI(int id)
        {
            return new CI(id, types.Get(id), customers.Get(id), attributes.GetAll(id));
        }

        public CI GetFromCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                int ciID = 0;
                string commandText = $"SELECT CIs.CI_ID FROM CIs INNER JOIN Customers ON Customers.CustomerID = CIs.CustomerID WHERE Customers.CustomerID = {customer.CustomerID}";
                SqlCommand cmd = new SqlCommand(commandText, conn);
                SqlDataReader reader;
                using(reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ciID = (int)reader[0];
                    }
                }
                return GetFromCI(ciID);
            }
        }

        public List<CI> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                List<CI> CIsToFind = new List<CI>();
                int ciCount = 0;
                string commandText = $"SELECT COUNT(*) FROM CIs";
                SqlCommand cmd = new SqlCommand(commandText, conn);
                SqlDataReader reader;
                using(reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ciCount = (int)reader[0];
                    }
                }

                for (int i = 1; i < ciCount+1; i++)
                {
                    CIsToFind.Add(GetFromCI(i));
                }
                return CIsToFind;
            }
        }

        public List<CI> GetAll(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                List<int> clientCIs = new List<int>();
                List<CI> listToFind = new List<CI>();
                string commandText = $"SELECT CI_ID FROM CIs WHERE CustomerID = {customer.CustomerID}";
                SqlCommand cmd = new SqlCommand(commandText, conn);
                SqlDataReader reader;
                using(reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientCIs.Add((int)reader[0]);
                    }
                }

                for (int i = 0; i < clientCIs.Count; i++)
                {
                    listToFind.Add(GetFromCI(clientCIs[i]));
                }
                return listToFind;
            }

        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public bool Update(CI fromItem, CI toItem)
        {
            throw new NotImplementedException();
        }
    }
}

