﻿using System.Collections.Generic;

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

        public void PrintAttrbutes()
        {
            foreach(CIAttributes a in Attributes)
            {
                System.Console.WriteLine(a.AttributeName);
                System.Console.WriteLine(a.AttributeValue);
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("ID " + CI_ID);
            System.Console.WriteLine("Komponent type " + @Type.TypeName);
            System.Console.WriteLine("Kunde " + Customer.CustomerName);

        }
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

        public void SetAttributes(List<CIAttributes> attributes)
        {
            Attributes = attributes;
        }
    }
}
