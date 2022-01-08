using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace DataAccess.Repositories
{
  public  class GenericRepository<T>:IGenericDal<T> where T:class
    {
        public List<T> GetAlList()
        {
            using (Context context=new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Add(T t)
        {
            using (Context context = new Context())
            {
                context.Add(t);
                context.SaveChanges();
            }
        }

        public void Delete(T t)
        {
            using (Context context = new Context())
            {
                context.Remove(t);
                context.SaveChanges();
            }
        }

        public void Update(T t)
        {
            using (Context context = new Context())
            {
                context.Update(t);
                context.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            using (Context context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> GetAlList(Expression<Func<T, bool>> filter)
        {
            using (Context context=new Context())
            {
                return context.Set<T>().Where(filter).ToList();
            }
        }
    }
}
