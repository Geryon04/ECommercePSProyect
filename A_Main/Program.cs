using System.Security.AccessControl;
using System;
using B_Infraestructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using C_Aplication.Interfaces;
using C_Aplication.UseCases;
using B_Infraestructure.Querys;
using B_Infraestructure.Commands;
using A_Main.MenuUser;


namespace A_Main;
class Program
{
    

    static void Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args).ConfigureServices((hostContext,services) => {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(@"Server=localhost,1433;Database=Espinosa_Juan;User Id=sa;Password=Nofuture04;TrustServerCertificate=true"));
            services.AddScoped<IProductService , ProductService>().BuildServiceProvider();
            services.AddScoped<IProductQuery , ProductQuery>().BuildServiceProvider();
            services.AddScoped<ISaleProductCommand , SaleProductCommand>().BuildServiceProvider();
            services.AddScoped<ISaleProductService , SaleProductService>().BuildServiceProvider();
        }).Build();
        
        var productRepository = host.Services.GetService<IProductService>();
        var saleProductRepository = host.Services.GetService<ISaleProductService>();

        

        OptionUserDispatcher dispatcher = new OptionUserDispatcher(productRepository , saleProductRepository);

        PrincipalMenu.MainMenu();
        int optionSelect = int.Parse(Console.ReadLine());
        dispatcher.OptionDispatcher(optionSelect);

        host.Run();      

    }
}