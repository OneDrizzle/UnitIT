using System;
using UnitITICBM.Persistance;

namespace UnitITICBM
{
    class Program
    {
        static void Main(string[] args)
        {
            AttributeRepositoryDB ardb = new AttributeRepositoryDB();
            ardb.PrintList(ardb.GetAll());
            Console.ReadLine();
        }
    }
}
