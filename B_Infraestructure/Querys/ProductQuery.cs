using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B_Infraestructure.Persistence;
using C_Aplication.Interfaces;
using D_Domain.Entities;

namespace B_Infraestructure.Querys
{
    public class ProductQuery : IProductQuery
    {
        private readonly AppDbContext _context;

        public ProductQuery(AppDbContext context){
            _context = context;
        }

        public List<Product> GetProductList(){
            var products = _context.Products.ToList();
            return products;
        }
    }
}