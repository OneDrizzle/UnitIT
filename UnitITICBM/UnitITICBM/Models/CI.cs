using System.Collections.Generic;

namespace UnitITICBM.Models
{
    public class CI
    {

        public int CI_ID { get; private set; }
        public Type @Type { get; private set; }
        public Customer Customer { get; private set; }

        public List<CIAttributes> Attributes { get; private set; }

        public CI(int cI_ID, Type type, Customer customer, List<CIAttributes> attributes)
        {
            CI_ID = cI_ID;
            @Type = type;
            Customer = customer;
            Attributes = attributes;
        }

    }
}
