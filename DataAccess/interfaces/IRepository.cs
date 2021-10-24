using Entitiess.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.interfaces
{
    interface IRepository<T> where T:Ientity
    {
        bool Create(T enntit);
        bool Update(T enntit);
        bool Delete(T enntit);
        List<T> GetAll(Predicate<T> filter = null);
        T Get(Predicate<T> filter=null);
    }
}
