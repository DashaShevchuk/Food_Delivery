using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Food_Delivery.Models;
using Microsoft.AspNetCore.Authorization;
using Food_Delivery.Services;
using Microsoft.AspNetCore.Http;
using Food_Delivery.Data.Interfaces;
using Food_Delivery.View_Models;

namespace Food_Delivery.Controllers
{
    [Authorize(Roles ="User")]
    public class HomeController : Controller
    {
        private readonly IProduct _products;
        public HomeController(IProduct products)
        {
            _products = products;
        }
        public ViewResult Index()
        {
            var products = new SaleProductsViewModel
            {
                SaleProducts = _products.GetSaleProducts
            };
            return View(products);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public ViewResult AddFilesForm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFilesForm(IFormFile uploadedFile)
        {
            FileService service = new FileService();
            await service.AddFile(uploadedFile);
            return RedirectToAction("Login", "Account");
        }
    }
}
