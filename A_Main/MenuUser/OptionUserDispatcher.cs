using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Aplication.Interfaces;
using C_Aplication.UseCases;



namespace A_Main.MenuUser
{
    public class OptionUserDispatcher
    {
        
        private readonly IProductService _service;
        private readonly ISaleProductService _saleProductService;
        public OptionUserDispatcher(IProductService service , ISaleProductService saleProductService){
            _service = service;
            _saleProductService = saleProductService;
        }

        public void OptionDispatcher(int option){
            ProductDetail productDetail = new ProductDetail(_service);
            SaleProductRegister register = new SaleProductRegister(_saleProductService , _service);
            SaleProductMenu saleMenu = new SaleProductMenu(register);
            switch (option)
            {
                case 1:
                    productDetail.ProductInformation();
                    break;
                case 2:
                    saleMenu.Menu();
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        }

        
    }
}