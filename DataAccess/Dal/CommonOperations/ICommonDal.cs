using Entities.ObsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dal.CommonOperations
{
    public interface ICommonDal<T> where T : class,new()
    {
        T Get(int id);
        T Add(T entity);
        bool Remove(T entity);
        List<T> GetList();
    }
}
