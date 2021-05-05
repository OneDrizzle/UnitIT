using System;
using System.Collections.Generic;
using System.Text;
using UnitITICBM.Models;

namespace UnitITICBM.Persistance
{
    public class CIServiceRepositoryDB
    {
        private List<CIService> cIServices;

        public CIServiceRepositoryDB()
        {
            cIServices = new List<CIService>();
        }
    }
}
