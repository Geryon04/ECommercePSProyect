using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_Main
{
    public class SaleProductMenu
    {
        private string product; 
         private readonly SaleProductRegister _register;

        public SaleProductMenu(SaleProductRegister register){
            _register = register;
        }
        public void Menu(){
            Console.WriteLine("ingrese un producto");
            product = Console.ReadLine();
            _register.SaleRegister(product);
            Console.WriteLine("Venta registrada");
        }
    }
}