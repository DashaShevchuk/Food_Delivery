﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food_Delivery.Data.Interfaces;
using Food_Delivery.Data.Models;
using Food_Delivery.View_Models;
using Microsoft.AspNetCore.Mvc;

namespace Food_Delivery.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProduct _product;
        private readonly ICategory _category;

        public ProductsController(IProduct product, ICategory category)
        {
            _product = product;
            _category = category;
        }
        [Route("Products/ListProducts")]
        [Route("Products/ListProducts/{category}")]
        public ViewResult ListProducts(string category)
        {
            IEnumerable<Product> products = null;
            string productCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                products = _product.GetProducts.OrderBy(i => i.Id);
            }
            else
            {
                products = _product.GetProducts
                    .Where(x => x.Category.
                    Name.ToUpper() == category.ToUpper());

                productCategory = category;
            }

            var productObj = new ProductListViewModel
            {
                GetProducts = products,
                ProductCategory = productCategory
            };
            return View(productObj);
        }
    }
}