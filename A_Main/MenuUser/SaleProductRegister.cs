
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D_Domain.Entities;
using C_Aplication.Interfaces;

namespace A_Main.MenuUser
{
    public class SaleProductRegister
    {
        private readonly ISaleProductService _service;
        private readonly IProductService _productService;
        public SaleProductRegister(ISaleProductService service, IProductService productService){
            _service = service;
            _productService = productService;
        }

        public SaleProduct SaleRegister(string productName){
            List<Product> productList = _productService.GetAllProducts();
            var saleProduct = new SaleProduct();
            foreach (var product in productList){
                if(product.Name.Equals(productName)){
                    saleProduct = _service.CreateSaleProduct(product);
                }
            }
            return saleProduct;
        }
    }
}