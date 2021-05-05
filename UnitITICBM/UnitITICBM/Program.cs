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

            CI testCI = new CI("sadasd", cRepo.types.Get(1), cRepo.customers.Get(2), cRepo.attributes.GetAll());

            cRepo.Add(testCI);
           

            Console.ReadLine();


        }
    }
}
