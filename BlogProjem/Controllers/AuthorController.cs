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
using Microsoft.AspNetCore.Authorization;

namespace BlogProjem.Controllers
{
    
    public class AuthorController : Controller
    {
        AuthorManager authorManager=new AuthorManager(new EfAuthorRepository());
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AuthorProfile()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }

        [AllowAnonymous]
        public PartialViewResult AuthorNavbarPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult AuthorEditProfile()
        {
            var authorValues = authorManager.GetById(1);
            return View(authorValues);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult AuthorEditProfile(Author author)
        {
            AuthorValidator authorValidator=new AuthorValidator();
            ValidationResult result = authorValidator.Validate(author);
            if (result.IsValid)
            {
                authorManager.TUpdate(author);
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
