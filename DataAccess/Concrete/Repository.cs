using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T: class,new()
    {
        DictionaryAdaptationContext context = new DictionaryAdaptationContext();
        DbSet<T> _object;

        public Repository()
        {

            _object = context.Set<T>();
        }

        public void Add(T entity)
        {
            _object.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _object.Remove(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public void Update(T entity)
        {
            context.SaveChanges();
        }
    }
}
