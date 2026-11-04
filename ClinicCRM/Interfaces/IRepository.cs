using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicCRM.Interfaces
{
    namespace ClinicCRM.Interfaces
    {
        public interface IRepository<T> where T : class
        {
            List<T> GetAll();
            T GetById(int id);
            void Add(T item);
        }
    }
}
