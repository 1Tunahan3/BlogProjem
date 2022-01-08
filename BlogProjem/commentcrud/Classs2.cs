using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;

namespace BlogProjem.commentcrud
{
    public class Classs2
    {
        CommentManager commentManager=new CommentManager(new EfCommentRepository());


        Comment comment = new Comment()
        {
            CommentUserName = "Tuana",
            CommentContent = "Güzel bir calisma olmus ama eksikler var",
            CommentTitle = "Yorum",
            CommentDate = DateTime.Now,
            CommentStatus = true
            
        };

        public void AddComment()
        {
            commentManager.AddComment(comment);
        }

       


    }
}
