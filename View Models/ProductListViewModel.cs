using Food_Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.View_Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> GetProducts { get; set; }
        public string ProductCategory { get; set; }
    }
}
