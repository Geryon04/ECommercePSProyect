using System.Security.AccessControl;
using System;
using B_Infraestructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using C_Aplication.Interfaces;
using C_Aplication.UseCases;
using B_Infraestructure.Querys;
using B_Infraestructure.Commands;

namespace A_Main;
class Program
{
    public static readonly IServiceCollection serviceDescriptors = ServiceProvider.Build(); 

    static void Main(string[] args)
    {
        //var builder = new ServiceCollection();
        //builder.AddDbContext<AppDbContext>(options => options.UseSqlServer("Server=localhost,1433;Database=demo;User Id=sa;Password=Nofuture04;TrustServerCertificate=true"));
        
        ProductDetail productDetail = new ProductDetail(new ProductService(new ProductQuery(new AppDbContext())));
        SaleProductRegister saleProductRegister = new SaleProductRegister(new SaleProductService(new SaleProductCommand(new AppDbContext())),new ProductService(new ProductQuery(new AppDbContext())) );
        SaleProductMenu menu = new SaleProductMenu(saleProductRegister);
        int option = 0;
        Console.WriteLine("ECommerce");
        Console.WriteLine("Ingrese una opcion:");
        Console.WriteLine("1) Mostrar lista de productos");
        Console.WriteLine("2) Registrar venta de un/varios productos");

        option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                productDetail.ProductInformation();
                break;
            case 2:
                menu.Menu();
                Console.WriteLine("option 2");
                break;
            default:
                Console.WriteLine("incorrect option");
                break;
        }


        

    }
}