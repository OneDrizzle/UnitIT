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

        public List<CIAttributes> GetAll(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();

                List<CIAttributes> attributesToFind = new List<CIAttributes>();
                string commmandText = $"SELECT Attributes.AttributeID, Attributes.AttributeName, CIAttributeMapping.AtrtibuteValue FROM CIs INNER JOIN CIAttributeMapping ON " +
                    $"CIs.CI_ID = CIAttributeMapping.CI_ID INNER JOIN Attributes ON Attributes.AttributeID = CIAttributeMapping.AttributeID WHERE CIs.CI_ID = {id}";

                SqlCommand cmd = new SqlCommand(commmandText, conn);
                SqlDataReader reader;
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        attributesToFind.Add(new CIAttributes((int)reader[0], (string)reader[1], (string)reader[2]));
                    }
                }
                return attributesToFind;
            }


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
