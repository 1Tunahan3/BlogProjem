using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace BlogProjem.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult>  Index(Author author)
        {
           Context context=new Context();
           var datavalue = context.Authors.FirstOrDefault(x =>
               x.AuthorMail == author.AuthorMail && x.AuthorPassword == author.AuthorPassword);
           if (datavalue!= null)
           {
               var claims = new List<Claim>
               {
                   new Claim(ClaimTypes.Name,author.AuthorMail)
               };
               var useridentity=new ClaimsIdentity(claims,"a");
               ClaimsPrincipal principal=new ClaimsPrincipal(useridentity);
               await HttpContext.SignInAsync(principal);
               return RedirectToAction("Index", "Blog");
           }
           else
           {
               return View();
           }

        }
    }
}

//Context context = new Context();
//var datavalue = context.Authors.FirstOrDefault(x =>
//x.AuthorMail == author.AuthorMail && x.AuthorPassword == author.AuthorPassword);
//if (datavalue != null)
//{
//HttpContext.Session.SetString("username", author.AuthorMail);
//return RedirectToAction("Index", "Blog");

//}
//else
//{
//return View();
//}
