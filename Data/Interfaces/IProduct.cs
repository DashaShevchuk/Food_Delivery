using Food_Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Data.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts { get; }
        IEnumerable<Product> GetSaleProducts { get; }
        Product GetProduct(int id);
    }
}
