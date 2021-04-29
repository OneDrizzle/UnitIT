using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using UnitITICBM.Models;

namespace UnitITICBM.Persistance
{
    public class CIRepository
    {
        private List<CI> cIs;
        private const string _tableName = "CIs";

        public CIRepository()
        {
            cIs = new List<CI>();
        }

        public void Add(CI item)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                //Opens DB connection
                conn.Open();

                //Saves data to table
                SqlCommand cmd = new SqlCommand($"INSERT INTO {_tableName}(CI_ID) VALUES (@CI_ID)", conn);
                cmd.Parameters.Add("@CI_ID", System.Data.SqlDbType.Int).Value = item.CI_ID;

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CI Get(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();

                // FINDS THE TYPE OF COMPONENT THROUGH CI ID AND CREATES TYPE OBJECT
                string commandText = $"SELECT CITypes.TypeID, CITypes.TypeName FROM CIs INNER JOIN CITypes ON CIs.TypeID = CITypes.TypeID WHERE CIs.CI_ID = {id}";
                SqlCommand cmd = new SqlCommand(commandText, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                Models.Type ciType = new Models.Type((int)reader[0], reader[1] as string ?? default); // ALLOWS TYPE NAME TO BE NULL ASWELL
                reader.Close();

                // REASSIGNS COMMANDTEXT TO FIND CUSTOMER THROUGH CI ID AND CREATES CUSTOMER OBJECT
                commandText = $"SELECT Customers.CustomerID, Customers.CustomerName FROM Customers INNER JOIN CIs ON CIs.CustomerID = Customers.CustomerID WHERE CIs.CI_ID = {id}";
                cmd = new SqlCommand(commandText, conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                Models.Customer ciCustomer = new Customer((int)reader[0], reader[1] as string ?? default);
                reader.Close();

                // CREATING LIST OF ATTRIBUTES AND LOADING THEM IND LINE BY LINE
                List<CIAttributes> tempList = new List<CIAttributes>();
                commandText = $"SELECT Attributes.AttributeID, Attributes.AttributeName, CIAttributeMapping.AtrtibuteValue FROM CIs INNER JOIN CIAttributeMapping ON" +
                    $" CIs.CI_ID = CIAttributeMapping.CI_ID INNER JOIN Attributes ON Attributes.AttributeID = CIAttributeMapping.AttributeID WHERE CIs.CI_ID = {id}";
                cmd = new SqlCommand(commandText, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tempList.Add(new CIAttributes((int)reader[0], reader[1] as string ?? default, reader[2] as string ?? default));
                }
                reader.Close();

                // THE WANTED CI IS CREATED AS AN OBJECT AND RETURNED
                CI newCI = new CI(id, ciType, ciCustomer, tempList);
                return newCI;


            }
        }

        


        public List<CI> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                List<CI> returnCI = new List<CI>();
                int id = 1;
                for (int i = 0; i < 10; i++)
                {
                    Get(id);
                    id++;
                }

                return returnCI;
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

