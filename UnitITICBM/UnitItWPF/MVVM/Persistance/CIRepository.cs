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

        public void Add(CI ci)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                string commandText = $"INSERT INTO dbo.CIs(CI_ID, CIName) VALUES ({ci.CI_ID}, {ci.CIName}";
                SqlCommand cmd = new SqlCommand(commandText, conn);
                cmd.Parameters.Add("@CI_ID", System.Data.SqlDbType.Int).Value = ci.CI_ID;
                cmd.Parameters.Add("@CIName", System.Data.SqlDbType.NVarChar).Value = ci.CIName;


                cmd.ExecuteNonQuery();
                
                
            }
        }
        public int Add(string name, Models.Type type, Customer customer, List<CIAttributes> attributes)
        {

            CI newCI = new CI(name, type, customer, attributes);
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                int id = 0;
                string commandText = $"INSERT INTO dbo.CIs(CIName) OUTPUT inserted.CI_ID VALUES {newCI.CIName}";
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    id = cmd.ExecuteNonQuery();
                }
                return id;
            };

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

        public List<CI> GetAll(int ID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                List<int> clientCIs = new List<int>();
                List<CI> listToFind = new List<CI>();
                string commandText = $"SELECT CI_ID FROM CIs WHERE CustomerID = {ID}";
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

