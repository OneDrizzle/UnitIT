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

    }
}
