using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D_Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set;}

        public IList<Product> Products { get; set; }

    }
}