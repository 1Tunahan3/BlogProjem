using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjem.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager categoryManager=new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = categoryManager.GetList();
            return View(values);
        }
    }
}
