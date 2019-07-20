using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApi.Core.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        T Insert(T obj);
        T Update(T obj);
        void Delete(T obj);
        T GetById(T obj);
        T GetAll(T obj);
    }
}
