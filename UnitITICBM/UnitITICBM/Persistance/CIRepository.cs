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

        //public CI Get(int id)
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
        //    {
        //        conn.Open();


        //        string commandText = $"SELECT * FROM CITypes WHERE TypeID = {id}";
        //        SqlCommand CMDTypes = new SqlCommand(commandText, conn);
        //        SqlDataReader readerType = CMDTypes.ExecuteReader();

        //        Models.Type type = new Models.Type(readerType[0] as int? ?? default, readerType[1] as string);


        //        SqlCommand CMDCustomer = new SqlCommand($"SELECT * FROM Customers WHERE CustomerID = {id}", conn);
        //        SqlDataReader readerCustomer = CMDCustomer.ExecuteReader();

        //        Customer customer = new Customer((int)readerCustomer[0], (string)readerType[1]);

        //        List<Models.CIAttributes> Testlist = new List<Models.CIAttributes>();

        //        Models.CIAttributes a = new Models.CIAttributes();
        //        Models.CIAttributes b = new Models.CIAttributes();
        //        Models.CIAttributes c = new Models.CIAttributes();
        //        Models.CIAttributes d = new Models.CIAttributes();
        //        Testlist.Add(a);
        //        Testlist.Add(b);
        //        Testlist.Add(c);
        //        Testlist.Add(d);

        //        return new CI(id, type, customer, Testlist);


        //    }
        //}

        public List<CI> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {

                List<CI> returnCI = new List<CI>();
                int id = 1;
                SqlCommand cmd = new SqlCommand("SELECT CI_ID FROM CIs");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
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

