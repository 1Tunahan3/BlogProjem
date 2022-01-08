using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
  public  interface IGenericDal<T> where T:class
  {
      List<T> GetAlList();
      void Add(T t);
      void Delete(T t);
      void Update(T t);
      T GetById(int id);
      List<T> GetAlList(Expression<Func<T, bool>> filter);
  }
}
