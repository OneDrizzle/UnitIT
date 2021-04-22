using System;
using System.Collections.Generic;
using System.Text;

namespace UnitITICBM.Persistance
{
    public class AttributeRepositoryDB:IRepo<Attribute>
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

        public Attribute GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Attribute> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public bool Update(Attribute fromItem, Attribute toItem)
        {
            throw new NotImplementedException();
        }
    }
}
