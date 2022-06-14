using Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class VYPSRepository<T> : IRepository<T> where T : class
    {
        private DbContext _dbContext;
        private DbSet<T> _dbSet;

        public VYPSRepository()
        {
            _dbContext = new VYPSContext();
            _dbSet = _dbContext.Set<T>();
        }

        public bool Add(T entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Added;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Delete(T entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Deleted;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<T> SelectAll(Expression<Func<T, bool>> filter = null)
        {
            return filter != null ? _dbSet.Where(filter).ToArray() : _dbSet.ToArray();
        }

        public T SelectSingle(Expression<Func<T, bool>> filter)
        {
            return filter != null ? _dbSet.Where(filter).FirstOrDefault() : _dbSet.FirstOrDefault();
        }

        public bool update(int id, T entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
