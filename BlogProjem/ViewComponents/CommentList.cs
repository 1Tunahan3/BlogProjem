using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProjem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjem.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName = "Tuna"
                },
                new UserComment()
                {
                    ID = 2,
                    UserName = "Mesut"
                },
                new UserComment
                {
                    ID = 3,
                    UserName = "OZIL"
                }
            };
            return View(commentvalues);
        }
    }
}
