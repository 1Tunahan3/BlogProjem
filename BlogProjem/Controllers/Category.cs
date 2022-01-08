using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.EntityFramework;

namespace BlogProjem.Controllers
{
    public class Category : Controller
    {
        CategoryManager categoryManager=new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = categoryManager.GetList();
            return View(values);
        }
    }
}
