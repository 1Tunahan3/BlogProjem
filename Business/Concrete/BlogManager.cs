using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
  public  class BlogManager:IBlogService
  {
      private IBlogDal _blogDal;

      public BlogManager(IBlogDal blogDal)
      {
          _blogDal = blogDal;
      }

      
        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TAdd(Blog t)
        {
            _blogDal.Add(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetList()
        {
            throw new NotImplementedException();
        }

      

        public List<Blog> GetBlogsWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetAlList(x => x.BlogID == id);
        }

        public List<Blog> GetListWithCategoryByAuthor(int id)
        {
            return _blogDal.GetListWithCategoryByAuthor(id);
        }

        public List<Blog> GetBlogListByAuthor(int id)
        {
            return _blogDal.GetAlList(x => x.AuthorID == id);
        }
  }
}
