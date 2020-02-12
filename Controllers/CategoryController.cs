using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food_Delivery.Data.Interfaces;
using Food_Delivery.Data.Models;
using Food_Delivery.View_Models;
using Microsoft.AspNetCore.Mvc;

namespace Food_Delivery.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }
        public ViewResult SideCategories()
        {
            CategoryViewModel category = new CategoryViewModel();
            IEnumerable<Category> categories = _category.GetCategories;
            category.GetCategory = categories;
            return View(category);
        }
    }
}