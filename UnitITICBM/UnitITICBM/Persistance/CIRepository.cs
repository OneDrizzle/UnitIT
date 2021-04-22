using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using UnitITICBM.Models;

namespace UnitITICBM.Persistance
{
    public class CIRepository: IRepo<CI>
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

        public CI GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<CI> GetAll()
        {
            throw new NotImplementedException();
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
