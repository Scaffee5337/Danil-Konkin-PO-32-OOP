using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeMasterConsole.Interfaces;

public interface IRepository<T> where T : class
{
    T GetById(int id);
    List<T> GetAll();
    void Add(T entity);
}
