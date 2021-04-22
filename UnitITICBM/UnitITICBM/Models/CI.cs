using System.Collections.Generic;

namespace UnitITICBM.Models
{
    public class CI
    {

        public int CI_ID { get; private set; }
        public Type type { get; private set; }
        public Customer Customer { get; private set; }

        public List<Attribute> Attributes { get; private set; }

        public CI(int cI_ID, Type type, Customer customer, List<Attribute> attributes)
        {
            CI_ID = cI_ID;
            this.type = type;
            Customer = customer;
            Attributes = attributes;
        }

    }
}
