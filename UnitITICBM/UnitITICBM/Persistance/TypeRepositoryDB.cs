using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UnitITICBM.Persistance
{
    public class TypeRepositoryDB: IRepo<Models.Type>
    {
        private List<Type> types;

        public TypeRepositoryDB()
        {
            types = new List<Type>();
        }

        public void Add(Models.Type item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Models.Type Get(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                Models.Type typeToFind = new Models.Type();
                string commandText = $"SELECT CITypes.TypeName FROM CITypes WHERE TypeID = {id}";
                SqlCommand cmd = new SqlCommand(commandText, conn);
                SqlDataReader reader;
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        typeToFind.SetID(id);
                        typeToFind.SetName((string)reader[0]);
                    }
                }
                return typeToFind;

            }

        }

        public List<Models.Type> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public bool Update(Models.Type fromItem, Models.Type toItem)
        {
            throw new NotImplementedException();
        }
    }
}
