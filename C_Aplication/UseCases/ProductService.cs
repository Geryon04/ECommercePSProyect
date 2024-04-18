using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Aplication.Interfaces;
using D_Domain.Entities;

namespace C_Aplication.UseCases
{
    public class ProductService : IProductService
    {
        private readonly IProductQuery _query;
        
        public ProductService(IProductQuery query){
            _query = query;
        }

        public List<Product> GetAllProducts(){
            var products = _query.GetProductList();
            return products;
        }
    }
}