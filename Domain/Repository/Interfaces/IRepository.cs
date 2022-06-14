using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository.Interfaces
{
   public interface IRepository<T> where T :class
    {
        T SelectSingle(Expression<Func<T, bool>> filter=null);
        IEnumerable<T> SelectAll(Expression<Func<T, bool>> filter=null);
        bool Add(T entity);
        bool Delete(T entity);
        bool update(int id, T entity);

    }
}
