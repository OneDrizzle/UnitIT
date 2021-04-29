using System;
using System.Collections.Generic;
using UnitITICBM.Persistance;

namespace UnitITICBM
{
    class Program
    {
        static void Main(string[] args)
        {
            CIRepository cRepo = new CIRepository();

            Models.CI temp = cRepo.Get(3);

            temp.PrintAttrbutes();

            //List<Models.CI> tempo = cRepo.GetAll();

            //tempo[0].PrintAttrbutes();
            //tempo[1].PrintAttrbutes();
            //tempo[2].PrintAttrbutes();

            Console.ReadLine();


        }
    }
}
