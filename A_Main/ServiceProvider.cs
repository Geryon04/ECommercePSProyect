using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using B_Infraestructure.Persistence;
using B_Infraestructure.Querys;
using C_Aplication.Interfaces;
using C_Aplication.UseCases;


namespace A_Main
{
    public class ServiceProvider
    {
        //private const string connectionString = @"Server=localhost,1433;Database=demo;User Id=sa;Password=Nofuture04;TrustServerCertificate=true";
    
        public static IServiceCollection Build()
        {
            IServiceCollection servicesList = new ServiceCollection();
            servicesList.AddScoped<IProductService , ProductService>();
            servicesList.AddScoped<IProductQuery , ProductQuery>();
                //.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString))
            return servicesList;
        }
        
    }
}