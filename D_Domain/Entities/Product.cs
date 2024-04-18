using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D_Domain.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        //public Uri Image { get; set; }

        public int Category { get; set; }
        public Category ProductCategory { get; set; }

        public IList<SaleProduct> SalesProducts { get; set; }
    }
}