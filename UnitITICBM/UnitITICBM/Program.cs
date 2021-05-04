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

            List<CI> testCI = cRepo.GetAll();

            foreach(CI x in testCI)
            {
                x.PrintAttrbutes();
            }

            Console.ReadLine();


        }
    }
}
