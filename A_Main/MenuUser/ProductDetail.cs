using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Aplication.Interfaces;
using D_Domain.Entities;

namespace A_Main.MenuUser
{
    public class ProductDetail
    {
        private readonly IProductService _service;

        public ProductDetail(IProductService service){
            _service = service;
        }

        public void ProductInformation(){
            List<Product> productos = _service.GetAllProducts();
            foreach (var producto in productos)
            {
                Console.WriteLine(
                    "Id: " + producto.ProductId + "\n" +
                    "Nombre: " + producto.Name + "\n" +
                    "Descripcion: " + producto.Description + "\n" +
                    "Precio: " + producto.Price + "\n" +
                    "Categoria: " + producto.Category + "\n" +
                    "Descuento: " + producto.Discount + "\n"
                );
            }
        }
    }
}