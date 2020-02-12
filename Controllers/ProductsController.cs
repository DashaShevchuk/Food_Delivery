using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food_Delivery.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Food_Delivery.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProduct _product;
        private readonly ICategory _category;

        public ProductsController(IProduct product, ICategory category)
        {

        }
    }
}