using System;
using System.Collections.Generic;
using UnitITICBM.Models;
using UnitITICBM.Persistance;

namespace UnitITICBM
{
    class Program
    {
        static void Main(string[] args)
        {
            CIRepository cRepo = new CIRepository(new AttributeRepositoryDB(), new CustomerRepositoryDB(), new TypeRepositoryDB());
            Customer c = cRepo.customers.Get(4);

            List<CI> testCI = cRepo.GetAll(c);

            foreach(CI x in testCI)
            {
                x.PrintAttrbutes();
            }

            Console.ReadLine();


        }
    }
}
