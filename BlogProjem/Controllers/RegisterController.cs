using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;

namespace BlogProjem.Controllers
{
    public class RegisterController : Controller
    {
        private AuthorManager authorManager = new AuthorManager(new EfAuthorRepository());
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Author author)
        {
            AuthorValidator authorValidator=new AuthorValidator();
            ValidationResult result = authorValidator.Validate(author);
            if (result.IsValid)
            {
                author.AuthorStatus = true;
            author.AuthorAbout = "test";
            authorManager.TAdd(author);
            return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();

        }
    }
}
