using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using UnitITICBM.Models;

namespace UnitITICBM.Persistance
{
    public class AttributeRepositoryDB
    {
        private List<Attribute> attributes;

        public AttributeRepositoryDB()
        {
            attributes = new List<Attribute>();
        }

        public void Add(Attribute item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Attribute Get(int id)
        {
            throw new NotImplementedException();
        }

        public Attribute GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<CIAttributes> GetAll()
        {
            List<CIAttributes> list = new List<CIAttributes>();

            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                //open connection
                conn.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.Attributes", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //reading data from table
                while (reader.Read())
                {
                    CIAttributes a = new CIAttributes((int)reader[0], (string)reader[1], reader[2] as string ?? default);
                    list.Add(a);
                }
                return list;
            }
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public bool Update(Attribute fromItem, Attribute toItem)
        {
            throw new NotImplementedException();
        }

        public void PrintList(List<CIAttributes> list) 
        {
            foreach(CIAttributes c in list)
            {
                Console.WriteLine(c.AttributeName);
            }
        }
        
    }
}
