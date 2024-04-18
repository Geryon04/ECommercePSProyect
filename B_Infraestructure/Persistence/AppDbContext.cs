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
           optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=Espinosa_Juan;User Id=sa;Password=Nofuture04;TrustServerCertificate=true");
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
                        Discount = 17},

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
                        Discount = 30},

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
                        Name = "Bufanda",
                        Description = "Bufanda de lana estampada desflecada",
                        Price = 3500,
                        Category = 3,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Cartera",
                        Description = "Cartera / Bandolera importada rígida matelasse soft cuadrado con doble broche imantado.  Manija corta fija y manija larga desmontable y regulable.",
                        Price = 12500,
                        Category = 3,
                        Discount = 5},

                    //Hogar y decoraccion
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Sillas de comedor",
                        Description = "Combo 4 Silla de Comedor Eames Home",
                        Price = 163017,
                        Category = 4,
                        Discount = 30},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Sillon individual",
                        Description = "Sillón Individual escandinavo CH25 Hansen",
                        Price = 971285,
                        Category = 4,
                        Discount = 25},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Mesa",
                        Description = "Mesa de Comedor Thora",
                        Price = 970697,
                        Category = 4,
                        Discount = 30},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Juego de living",
                        Description = "Juego de Living de 3 Sillones + Mesa Salerno",
                        Price = 2881015,
                        Category = 4,
                        Discount = 25},

                    //Salud y belleza
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de limpieza",
                        Description = "Kit doble de limpieza para pieles grasas libra niacinamida",
                        Price = 18697,
                        Category = 5,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Kit para piel cabelluda",
                        Description = "Kit Regulacion Piel Cabelluda Mixta/grasa( Incluye Neceser + Instructivo de uso)",
                        Price = 36600,
                        Category = 5,
                        Discount = 13},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Serum bifasico",
                        Description = "Serum bifasico revitalizante con niacinamida y agua de rosas",
                        Price = 5000,
                        Category = 5,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Suero hialuronico",
                        Description = "Suero hialuronico + niacinamida marca Libra Cosmetica",
                        Price = 6752,
                        Category = 5,
                        Discount = 0},

                    //Deportes y ocio
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Zapatillas Deportivas",
                        Description = "Zapatillas deportivas de entrenamiento Topper Squat",
                        Price = 50000,
                        Category = 6,
                        Discount = 12},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Shorts deportivos",
                        Description = "Shorts Alfest - futbol, running, basquet, gimnasio",
                        Price = 4440,
                        Category = 6,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Bote inflable",
                        Description = "Bestway 61052 bote inflable viaje/ocio",
                        Price = 21880,
                        Category = 6,
                        Discount = 10},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Tabla de surf",
                        Description = "Tabla de surf 5.10 A 6.4 Stickwave",
                        Price = 863000,
                        Category = 6,
                        Discount = 20},

                    //Juguetes y juegos
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Jenga",
                        Description = "Jenga de mesa 54 piezas Wiss Toy",
                        Price = 9900,
                        Category = 7,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Set de policia",
                        Description = "Set policia super realista, 6 piezas  con helicoptero - 10909",
                        Price = 5520,
                        Category = 7,
                        Discount = 10},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Juego de encastre",
                        Description = "Momodisk - Juego de encastre gigante de 25 piezas",
                        Price = 48500,
                        Category = 7,
                        Discount = 15},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Camion de juguete",
                        Description = "Camion militar desarmable de juguete con herramientas",
                        Price = 2400,
                        Category = 7,
                        Discount = 0},

                    //Alimentos y bebidas
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Leche entera",
                        Description = "Leche entera larga vida Veronica Tetra x 1Lt",
                        Price = 478,
                        Category = 8,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Coca-Cola",
                        Description = "Coca-Cola original, gaseosa sabor cola",
                        Price = 2900,
                        Category = 8,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Pure de tomate",
                        Description = "Pure de tomate Noel Brick x 520 Gr",
                        Price = 970,
                        Category = 8,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Jugo en polvo",
                        Description = "Jugo en polvo Arcor Naranja dulce 18 Gr",
                        Price = 250,
                        Category = 8,
                        Discount = 0},

                    //Libros y material educativo
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Redes de computadoras",
                        Description = "Libro 'Redes de computadoras' de Andrew S. Tanenbaum Nva Edicion",
                        Price = 58000,
                        Category = 9,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Flashcards de anatomia",
                        Description = "Libro 'Netter flashcards de anatomia: miembros' de John Hansen ",
                        Price = 40153,
                        Category = 9,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "El señor de los anillos",
                        Description = "coleccion El señor de los anillos - Tolkien - Set x 3 libros",
                        Price = 39900,
                        Category = 9,
                        Discount = 10},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Dune",
                        Description = "Saga de libros Dune 1-6 - Frank Herbert",
                        Price = 109000,
                        Category = 9,
                        Discount = 14},

                    //Jardineria y bricolaje
                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de jardineria",
                        Description = "Kit de herramientas de jardineria Acero inoxidable C/bolsa",
                        Price = 398689,
                        Category = 10,
                        Discount = 30},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Fumigador",
                        Description = "Pulverizador fumigador para jardineria 2l Harden",
                        Price = 2388,
                        Category = 10,
                        Discount = 0},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de bricolaje",
                        Description = "Kit de herramientas de bricolaje para el hogar 25 piezas",
                        Price = 138460,
                        Category = 10,
                        Discount = 15},

                    new Product{
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de silicona",
                        Description = "Kit de fabricacion de mldes de silicona AB 1:1 para bricolaje",
                        Price = 13886,
                        Category = 10,
                        Discount = 0}
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