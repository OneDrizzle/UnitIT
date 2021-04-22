using System;
using System.Collections.Generic;
using System.Text;

namespace UnitITICBM.Models
{
    public class Attribute
    {

        public int AttributeID { get; private set; }
        public string AttributeName { get; private set; }
        public string AttributeValue { get; private set; }
        public string TemplateName { get; private set; }

        public Attribute(int attributeID, string attributeName, string attributeValue)
        {
            AttributeID = attributeID;
            AttributeName = attributeName;
            AttributeValue = attributeValue;
        }

        public void AssignTemplate(string templateName)
        {
            TemplateName = templateName;
        }

    }
}
