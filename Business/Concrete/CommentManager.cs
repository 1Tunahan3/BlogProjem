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
   public class CommentManager:ICommentService
   {
       private ICommentDal _commentDal;

       public CommentManager(ICommentDal commentDal)
       {
           _commentDal = commentDal;
       }
        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        

        public List<Comment> GetAllComments(int id)
        {
            return _commentDal.GetAlList(x => x.BlogID == id);
        }
    }
}
