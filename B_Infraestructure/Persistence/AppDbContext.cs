using System.Runtime.InteropServices;
using System.Xml;
using System.Reflection.Metadata;
using System.Collections.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using D_Domain.Entities;

namespace B_Infraestructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SaleProduct> SalesProducts { get; set; }

        public AppDbContext(){

        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
           optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=demo;User Id=sa;Password=Nofuture04;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("Sale");
                entity.HasKey(e => e.SaleId);
                entity.Property(e => e.SaleId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");
                entity.HasKey(e => e.ProductId);
                entity.Property(e => e.ProductId).ValueGeneratedOnAdd();
                entity.HasOne<Category>(e => e.ProductCategory)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.Category);
                entity.HasData(
                    //Electrodomesticos
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Aire acondicionado",
                        Description = "Aire acondicionado split frio/calor Carrier XPower 5120W 4400F 53HVG1801E",
                        Price = 1199999,
                        Category = 1,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Smart TV",
                        Description = "Smart TV 32 pulgadas HD Android TV Admiral AD32E3A",
                        Price = 199999,
                        Category = 1,
                        Discount = 3},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Lavaropas Carga Frontal",
                        Description = "Lavaropas carga frontal 6kg 800 RPM Drean Next 6.08 ECO",
                        Price = 669999,
                        Category = 1,
                        Discount = 24},

                    //Tecnologia y electronica
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Celular Samsung",
                        Description = "Celular Samsung Galaxy A14 128GB Black",
                        Price = 239999,
                        Category = 2,
                        Discount = 33},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Celular Xiaomi",
                        Description = "Celular Xiaomi Redmi Note 11 128GB Negro",
                        Price = 339999,
                        Category = 2,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Notebook Lenovo",
                        Description = "Notebook Lenovo IdeaPad 1 14 pulgadas Intel Celeron 4GB 128GB SSD 82V60027AR",
                        Price = 699999,
                        Category = 2,
                        Discount = 14},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Impresora multifuncion",
                        Description = "Impresora Multifunción HP Deskjet 2775",
                        Price = 189999,
                        Category = 2,
                        Discount = 10},

                    //Moda y accesorios
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Campera",
                        Description = "Campera canguro ride",
                        Price = 51999,
                        Category = 3,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Buzo",
                        Description = "Buzo Anorak new fit",
                        Price = 43999,
                        Category = 3,
                        Discount = 45},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    //Hogar y decoraccion
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    //Salud y belleza
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    //Deportes y ocio
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    //Juguetes y juegos
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    //Alimentos y bebidas
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    //Libros y material educativo
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    //Jardineria y bricolaje
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Heladera con freezer",
                        Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                        Price = 632798,
                        Category = 1,
                        Discount = 7}
                );
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
                entity.HasKey(e => e.CategoryId);
                entity.Property(e => e.CategoryId);
                entity.HasData(
                    new Category{
                        CategoryId = 1,
                        Name = "Electrodomésticos"
                    },
                    new Category{
                        CategoryId = 2,
                        Name = "Tecnología y Electrónica"
                    },
                    new Category{
                        CategoryId = 3,
                        Name = "Moda y Accesorios"
                    },
                    new Category{
                        CategoryId = 4,
                        Name = "Hogar y Decoración"
                    },
                    new Category{
                        CategoryId = 5,
                        Name = "Salud y Belleza"
                    },
                    new Category{
                        CategoryId = 6,
                        Name = "Deportes y Ocio"
                    },
                    new Category{
                        CategoryId = 7,
                        Name = "Juguetes y Juegos"
                    },
                    new Category{
                        CategoryId = 8,
                        Name = "Alimentos y Bebidas"
                    },
                    new Category{
                        CategoryId = 9,
                        Name = "Libros y Material Educativo"
                    },
                    new Category{
                        CategoryId = 10,
                        Name = "Jardineriay Bricolaje"
                    }
                );
            });

            modelBuilder.Entity<SaleProduct>(entity =>
            {
                entity.ToTable("SaleProduct");
                entity.HasKey(e => e.ShoppingCardId);
                entity.Property(e => e.ShoppingCardId).ValueGeneratedOnAdd();

                entity.HasOne<Sale>(e => e.IndividualSale)
                .WithMany(e => e.SalesProducts)
                .HasForeignKey(e => e.Sale);

                entity.HasOne<Product>(e => e.IndividualProduct)
                .WithMany(e => e.SalesProducts)
                .HasForeignKey(e => e.Product);
            });
            
        }
    }
}