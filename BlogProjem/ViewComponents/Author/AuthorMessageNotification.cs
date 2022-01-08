using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjem.ViewComponents.Author
{
    public class AuthorMessageNotification: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
