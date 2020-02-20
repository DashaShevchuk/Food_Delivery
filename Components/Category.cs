using Food_Delivery.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Components
{
    public class Category: ViewComponent
    {
        private readonly ICategory _category;
        public Category(ICategory category)
        {
            _category = category;
        }
        public IViewComponentResult Invoke()
        {
            var category = _category.GetCategories;
            return View(category);
        }
    }
}
