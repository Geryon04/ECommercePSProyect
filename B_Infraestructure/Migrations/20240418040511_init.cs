using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace B_Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taxes = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.SaleId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_Category",
                        column: x => x.Category,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleProduct",
                columns: table => new
                {
                    ShoppingCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Sale = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleProduct", x => x.ShoppingCardId);
                    table.ForeignKey(
                        name: "FK_SaleProduct_Product_Product",
                        column: x => x.Product,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleProduct_Sale_Sale",
                        column: x => x.Sale,
                        principalTable: "Sale",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Electrodomésticos" },
                    { 2, "Tecnología y Electrónica" },
                    { 3, "Moda y Accesorios" },
                    { 4, "Hogar y Decoración" },
                    { 5, "Salud y Belleza" },
                    { 6, "Deportes y Ocio" },
                    { 7, "Juguetes y Juegos" },
                    { 8, "Alimentos y Bebidas" },
                    { 9, "Libros y Material Educativo" },
                    { 10, "Jardineriay Bricolaje" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("082551f9-e2fa-4f79-b182-2575a618946e"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("0b7dd95f-2912-4167-8f36-5bf97bc907b9"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("17bb0212-c7d0-4922-a932-799eae04a532"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("207ea6ce-4af8-4415-b0cd-f980c9cecf11"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("27b7bdeb-35ec-4f36-b730-f4b6c3abbddd"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("27f3bef3-3e4d-4e9b-8e4e-ac6bfd39512a"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("28a4c027-20e9-4729-8b72-906c4f0474d4"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("2bdb33f3-ad42-4a21-b6df-2ee1fd9c9b0d"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("2c137e3f-5796-4b28-b0a3-89070f909c6c"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("2d6e12ca-19e3-454f-9829-3f04482f5854"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("35b8d543-5d79-4c53-8da0-c9c746141d42"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("374dad6c-aeea-461e-a492-a252c89a062b"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("41725ec3-dbe4-43c5-b3a5-b7fb65fe5c69"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("422ec205-ce04-4732-a55d-5b56cbc85276"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("491294f5-91b6-4e6d-a4d1-5e2dcfd0298e"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("51082c06-a453-4ced-b9a5-85647bfccc9e"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("5e5d598c-58d3-4dcb-8bd6-6de38bd498a2"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("6a5cad6a-a018-4aa8-bfc6-1a2fb065fc3d"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("90ecba36-238e-46b1-afc1-c5246b0640c7"), 1, "Aire acondicionado split frio/calor Carrier XPower 5120W 4400F 53HVG1801E", 0, "Aire acondicionado", 1199999m },
                    { new Guid("98b80cca-4ec8-4009-9dad-baf803fa14ed"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("9baf0449-59f0-4626-a933-f8f167c5d330"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("9cec510f-8274-4fb3-92da-e16f3c579fe9"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("a6cdf38a-6beb-4882-b23e-4ab9f939deed"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("a769887c-cb09-4c8b-9186-5ff07decd3f4"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("ab584c41-a5d8-4075-a7be-3f33e1457a53"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("ae52134e-29bf-4553-a846-2f7bee89cc57"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("afe2b58c-22b1-4325-ba78-2e04dc673983"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("bfc4379e-33c2-42e5-8926-2e26b1303166"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("cf45b10a-e547-4dae-b7ba-801ce9d5d78a"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("d18dfe47-448a-46c7-97a4-8660d90010a9"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("d4389a45-fe4a-4f32-8866-94e9676fc46c"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("d6cb5e7a-e288-4f6e-8cda-62cb4471a534"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("d9ecff48-785f-4257-9a38-b00fb53c458c"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("da703c7c-f765-49ff-8ab5-e1d2e7c05556"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("e0b623b0-f321-4750-9568-65c48ff4a0bc"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("e23ddcc8-203c-4071-a2d4-b590e68ad1b2"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("e4f57310-e28d-43c6-a523-be05839a5f69"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m },
                    { new Guid("e5cd0791-fdd9-4d59-8022-6c14018f2e04"), 1, "Lavaropas crgafrontal 6kg 800 RPM Drean Next 6.08 ECO", 24, "Lavaropas Carga Frontal", 669999m },
                    { new Guid("ee781e9c-554a-4fe1-9057-6c9524c0dcea"), 1, "Smart TV 32 pulgadas HD Android TV Admiral AD32E3A", 3, "Smart TV", 199999m },
                    { new Guid("f612a300-26d4-44e0-938e-a272fa6c636b"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 7, "Heladera con freezer", 632798m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category",
                table: "Product",
                column: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_SaleProduct_Product",
                table: "SaleProduct",
                column: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_SaleProduct_Sale",
                table: "SaleProduct",
                column: "Sale");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleProduct");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
