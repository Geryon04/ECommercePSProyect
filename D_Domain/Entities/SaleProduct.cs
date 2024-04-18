using System.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D_Domain.Entities
{
    public class SaleProduct
    {
        public int ShoppingCardId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }

        public int Sale { get; set; }
        public Sale IndividualSale{ get; set; }

        public Guid Product { get; set; }
        public Product IndividualProduct { get; set; }
    }
}