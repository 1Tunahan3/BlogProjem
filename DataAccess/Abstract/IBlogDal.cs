using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace DataAccess.Abstract
{
  public  interface IBlogDal:IGenericDal<Blog>
  {
      List<Blog> GetListWithCategory();
      List<Blog> GetListWithCategoryByAuthor(int id);
  }
}
