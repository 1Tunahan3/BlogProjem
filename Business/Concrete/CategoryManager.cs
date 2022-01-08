using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;

namespace Business.Concrete
{
   public class CategoryManager:ICategoryService
   {
       private ICategoryDal _categoryDal;

       public CategoryManager(ICategoryDal categoryDal)
       {
           _categoryDal = categoryDal;
       }


       public void TDelete(Category t)
       {
           _categoryDal.Delete(t);
       }

       public void TAdd(Category t)
       {
           _categoryDal.Add(t);
       }

       public void TUpdate(Category t)
       {
          _categoryDal.Update(t);
       }

       public Category GetById(int id)
       {
           return _categoryDal.GetById(id);
       }


       public List<Category> GetList()
       {
           return _categoryDal.GetAlList();
       }

       
   }
}
