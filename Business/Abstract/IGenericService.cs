using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IGenericService<T>
    {

        void TDelete(T t);

        void TAdd(T t);

        void TUpdate(T t);

        T GetById(int id);

        List<T> GetList();
    }
}
