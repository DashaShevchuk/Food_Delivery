using Food_Delivery.Data.EFContext;
using Food_Delivery.Data.Interfaces;
using Food_Delivery.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Data.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly EFDbContext _context;
        public ProductRepository(EFDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProducts => _context.Products.Include(x => x.Category);

        public Product GetProduct(int ProductId) => _context.Products.FirstOrDefault(c => c.Id == ProductId);
    }
}
