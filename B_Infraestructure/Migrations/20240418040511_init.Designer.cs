﻿// <auto-generated />
using System;
using B_Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace B_Infraestructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240418040511_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("D_Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Electrodomésticos"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Tecnología y Electrónica"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Moda y Accesorios"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Hogar y Decoración"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Salud y Belleza"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Deportes y Ocio"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "Juguetes y Juegos"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "Alimentos y Bebidas"
                        },
                        new
                        {
                            CategoryId = 9,
                            Name = "Libros y Material Educativo"
                        },
                        new
                        {
                            CategoryId = 10,
                            Name = "Jardineriay Bricolaje"
                        });
                });

            modelBuilder.Entity("D_Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("Category");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("27f3bef3-3e4d-4e9b-8e4e-ac6bfd39512a"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("90ecba36-238e-46b1-afc1-c5246b0640c7"),
                            Category = 1,
                            Description = "Aire acondicionado split frio/calor Carrier XPower 5120W 4400F 53HVG1801E",
                            Discount = 0,
                            Name = "Aire acondicionado",
                            Price = 1199999m
                        },
                        new
                        {
                            ProductId = new Guid("ee781e9c-554a-4fe1-9057-6c9524c0dcea"),
                            Category = 1,
                            Description = "Smart TV 32 pulgadas HD Android TV Admiral AD32E3A",
                            Discount = 3,
                            Name = "Smart TV",
                            Price = 199999m
                        },
                        new
                        {
                            ProductId = new Guid("e5cd0791-fdd9-4d59-8022-6c14018f2e04"),
                            Category = 1,
                            Description = "Lavaropas crgafrontal 6kg 800 RPM Drean Next 6.08 ECO",
                            Discount = 24,
                            Name = "Lavaropas Carga Frontal",
                            Price = 669999m
                        },
                        new
                        {
                            ProductId = new Guid("d9ecff48-785f-4257-9a38-b00fb53c458c"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("ae52134e-29bf-4553-a846-2f7bee89cc57"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("5e5d598c-58d3-4dcb-8bd6-6de38bd498a2"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("207ea6ce-4af8-4415-b0cd-f980c9cecf11"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("9baf0449-59f0-4626-a933-f8f167c5d330"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("bfc4379e-33c2-42e5-8926-2e26b1303166"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("17bb0212-c7d0-4922-a932-799eae04a532"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("afe2b58c-22b1-4325-ba78-2e04dc673983"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("cf45b10a-e547-4dae-b7ba-801ce9d5d78a"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("e0b623b0-f321-4750-9568-65c48ff4a0bc"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("082551f9-e2fa-4f79-b182-2575a618946e"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("35b8d543-5d79-4c53-8da0-c9c746141d42"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("28a4c027-20e9-4729-8b72-906c4f0474d4"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("2c137e3f-5796-4b28-b0a3-89070f909c6c"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("422ec205-ce04-4732-a55d-5b56cbc85276"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("e23ddcc8-203c-4071-a2d4-b590e68ad1b2"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("a6cdf38a-6beb-4882-b23e-4ab9f939deed"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("6a5cad6a-a018-4aa8-bfc6-1a2fb065fc3d"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("2bdb33f3-ad42-4a21-b6df-2ee1fd9c9b0d"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("98b80cca-4ec8-4009-9dad-baf803fa14ed"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("2d6e12ca-19e3-454f-9829-3f04482f5854"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("d4389a45-fe4a-4f32-8866-94e9676fc46c"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("a769887c-cb09-4c8b-9186-5ff07decd3f4"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("e4f57310-e28d-43c6-a523-be05839a5f69"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("f612a300-26d4-44e0-938e-a272fa6c636b"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("d18dfe47-448a-46c7-97a4-8660d90010a9"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("491294f5-91b6-4e6d-a4d1-5e2dcfd0298e"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("374dad6c-aeea-461e-a492-a252c89a062b"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("da703c7c-f765-49ff-8ab5-e1d2e7c05556"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("41725ec3-dbe4-43c5-b3a5-b7fb65fe5c69"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("27b7bdeb-35ec-4f36-b730-f4b6c3abbddd"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("ab584c41-a5d8-4075-a7be-3f33e1457a53"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("51082c06-a453-4ced-b9a5-85647bfccc9e"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("9cec510f-8274-4fb3-92da-e16f3c579fe9"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("0b7dd95f-2912-4167-8f36-5bf97bc907b9"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        },
                        new
                        {
                            ProductId = new Guid("d6cb5e7a-e288-4f6e-8cda-62cb4471a534"),
                            Category = 1,
                            Description = "Heladera con freezer Marca Dream Hdr280f00b blanca clase A",
                            Discount = 7,
                            Name = "Heladera con freezer",
                            Price = 632798m
                        });
                });

            modelBuilder.Entity("D_Domain.Entities.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Taxes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPay")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SaleId");

                    b.ToTable("Sale", (string)null);
                });

            modelBuilder.Entity("D_Domain.Entities.SaleProduct", b =>
                {
                    b.Property<int>("ShoppingCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCardId"));

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("Product")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Sale")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCardId");

                    b.HasIndex("Product");

                    b.HasIndex("Sale");

                    b.ToTable("SaleProduct", (string)null);
                });

            modelBuilder.Entity("D_Domain.Entities.Product", b =>
                {
                    b.HasOne("D_Domain.Entities.Category", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("D_Domain.Entities.SaleProduct", b =>
                {
                    b.HasOne("D_Domain.Entities.Product", "IndividualProduct")
                        .WithMany("SalesProducts")
                        .HasForeignKey("Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("D_Domain.Entities.Sale", "IndividualSale")
                        .WithMany("SalesProducts")
                        .HasForeignKey("Sale")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IndividualProduct");

                    b.Navigation("IndividualSale");
                });

            modelBuilder.Entity("D_Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("D_Domain.Entities.Product", b =>
                {
                    b.Navigation("SalesProducts");
                });

            modelBuilder.Entity("D_Domain.Entities.Sale", b =>
                {
                    b.Navigation("SalesProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
