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
        public OptionUserDispatcher(IProductService service){
            _service = service;
        }

        public void OptionDispatcher(int option){
            ProductDetail productDetail = new ProductDetail(_service);
            switch (option)
            {
                case 1:
                    productDetail.ProductInformation();
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        }

        
    }
}