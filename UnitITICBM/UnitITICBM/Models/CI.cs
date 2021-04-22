using System.Collections.Generic;

namespace UnitITICBM.Models
{
    public class CI
    {

        public int CI_ID { get; private set; }
        public Type type { get; private set; }
        public Customer customer { get; private set; }

        public List<Attribute> attributes { get; private set; } = new List<Attribute>();

        public CI(int cI_ID, Type type, Customer customer, Attribute attribute)
        {

        }

    }
}
