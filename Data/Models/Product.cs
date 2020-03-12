using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Ingredients { get; set; }
        public int Weight { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
        public bool Sale { get; set; }
        public bool IsOrdered { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
