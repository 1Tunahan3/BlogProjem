using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjem.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager commentManager=new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.GetAllComments(id);
            return View(values);
            
        }
    }
}
