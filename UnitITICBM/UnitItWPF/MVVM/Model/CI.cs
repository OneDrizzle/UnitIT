using System.Collections.Generic;

namespace UnitITICBM.Models
{
    public class CI
    {

        public int CI_ID { get; private set; }
        public Type @Type { get; private set; }
        public Customer Customer { get; private set; }
        public string CIName { get;  set; }

        public string Attributes
        {
            get
            {
                string result = "";

                foreach (CIAttributes item in privAttributes)
                {
                    result = result + item.AttributeName +  " " + item.AttributeValue + "\n";
                }
                return result;
            }
        }

        private List<CIAttributes> privAttributes;

        public CI(int cI_ID, Type type, Customer customer, List<CIAttributes> attributes)
        {
            CI_ID = cI_ID;
            @Type = type;
            Customer = customer;
           //Attributes = attributes;
            privAttributes = attributes;
        }
        public CI(string name, Type type, Customer customer, List<CIAttributes> attributes)
        {
            CIName = name;
            @Type = type;
            Customer = customer;
            //Attributes = attributes;
            privAttributes = attributes;
        }

        /*public void PrintAttrbutes()
        {
            foreach (CIAttributes a in Attributes)
            {
                System.Console.WriteLine(a.AttributeName);
                System.Console.WriteLine(a.AttributeValue);
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("ID " + CI_ID);
            System.Console.WriteLine("");
            System.Console.WriteLine("Komponent type " + @Type.TypeName);
            System.Console.WriteLine("");
            System.Console.WriteLine("Kunde " + Customer.CustomerName);
        
        }*/
        public CI()
        {

        }

        public void SetType(Type type)
        {
            this.Type = type;
        }

        public void SetCustomer(Customer customer)
        {
            Customer = customer;
        }
        public void SetID(int id)
        {
            CI_ID = id;
        }

        /*public void SetAttributes(List<CIAttributes> attributes)
        {
            Attributes = attributes;
        }*/

       

    }
}
