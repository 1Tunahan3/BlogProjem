using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace Business.Abstract
{
   public interface ICommentService
    {
        //void DeleteCategory(Comment comment);

        void AddComment(Comment comment);

        //void UpdateCategory(Comment comment);

        //Comment GetById(int id);

        List<Comment> GetAllComments(int id);
    }
}
