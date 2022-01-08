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

namespace BlogProjem.Views.Category
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager blogManager=new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var value = blogManager.GetBlogsWithCategory();
            return View(value);
        }

        public IActionResult BlogListByAuthor()
        {
           var values= blogManager.GetListWithCategoryByAuthor(1);
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = blogManager.GetBlogByID(id);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {

            BlogValidator blogValidator = new BlogValidator();
            ValidationResult result = blogValidator.Validate(blog);
            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate=DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.AuthorID = 1;
                blogManager.TAdd(blog);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogValue = blogManager.GetById(id);
            blogManager.TDelete(blogValue);
            return RedirectToAction("BlogListByAuthor");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {

            var Blogvalue = blogManager.GetById(id);
            return View(Blogvalue);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            blog.AuthorID = 1;
            blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.BlogStatus = true;
            blogManager.TUpdate(blog);
            return RedirectToAction("BlogListByAuthor");
        }
    }
}
