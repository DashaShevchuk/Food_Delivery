using Food_Delivery.Data.EFContext;
using Food_Delivery.Data.Interfaces;
using Food_Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Data.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly EFDbContext _context;
        public CategoryRepository(EFDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetCategories => _context.Categories;
    }
}
