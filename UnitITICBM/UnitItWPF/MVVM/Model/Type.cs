using System;
using System.Collections.Generic;
using System.Text;

namespace UnitITICBM.Models
{
    public class Type
    {

        public int TypeID { get; private set; }
        public string TypeName { get; private set; }

        public Type(int typeID, string typeName)
        {
            TypeID = typeID;
            TypeName = typeName;
        }
        public Type()
        {

        }

        public void SetID(int id)
        {
            TypeID = id;
        }
        public void SetName(string name)
        {
            TypeName = name;
        }

        public override string ToString()
        {
            return TypeName;
        }

    }
}
