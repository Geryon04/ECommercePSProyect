using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Aplication.Interfaces;
using D_Domain.Entities;


namespace C_Aplication.UseCases
{
    public class SaleProductService : ISaleProductService
    {
        private readonly ISaleProductCommand _command;
        public SaleProductService(ISaleProductCommand command){
            _command = command;
        }

        public SaleProduct CreateSaleProduct(Product product){
            decimal total = (product.Price - product.Discount) * 1.21M;
            Sale sale = new Sale{
                SubTotal = product.Price,
                TotalDiscount = product.Discount,
                Taxes = 1.21M,
                TotalPay = total,
                Date = DateTime.Now
            };
            SaleProduct saleProduct = new SaleProduct{
                Sale = sale.SaleId,
                Product = product.ProductId,
                Quantity = 1,
                Price = product.Price,
                Discount = product.Discount,
            };
            _command.InsertSaleProduct(sale , saleProduct);
            return saleProduct;
        }
        
    }
}