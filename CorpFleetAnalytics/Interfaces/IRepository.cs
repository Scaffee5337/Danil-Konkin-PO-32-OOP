using System;
using System.Collections.Generic;
using System.Text;

namespace CorpFleetAnalytics.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T item);
        bool Delete(int id);
    }
}
