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
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;
        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void TDelete(Author t)
        {
            _authorDal.Delete(t);
        }

        public void TAdd(Author t)
        {
            _authorDal.Add(t);
        }

        public void TUpdate(Author t)
        {
            _authorDal.Update(t);
        }

        public Author GetById(int writerId)
        {
            return _authorDal.GetById(writerId);
        }


        public List<Author> GetWriterById(int id)
        {
            return _authorDal.GetAlList(x => x.AuthorID == id);
        }

        public List<Author> GetList()
        {
         return   _authorDal.GetAlList();
        }
    }
}
