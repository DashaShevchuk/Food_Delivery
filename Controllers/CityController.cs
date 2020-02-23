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
    public class CityController : Controller
    {
        private readonly ICity _city;
        public CityController(ICity city)
        {
            _city = city;
        }

        public IEnumerable<City> GetCities => throw new NotImplementedException();

        public ViewResult ListCities()
        {
            CitiesViewModel city = new CitiesViewModel();
            IEnumerable<City> cities = _city.GetCities;
            city.GetCities = cities;
            return View(city);
        }
    }
}