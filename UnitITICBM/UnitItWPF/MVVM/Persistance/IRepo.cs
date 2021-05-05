using System;
using System.Collections.Generic;
using System.Text;
using UnitITICBM.Models;

namespace UnitITICBM.Persistance
{
    public interface IRepo<T>
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T item);
        bool Update(T fromItem, T toItem);
        void Delete(int id);
        void Refresh();
    }
}
