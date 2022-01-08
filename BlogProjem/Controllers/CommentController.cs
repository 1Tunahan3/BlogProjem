using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.EntityFramework;

namespace BlogProjem.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager=new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = commentManager.GetAllComments(id);
            return PartialView(values);
        }

    }
}
