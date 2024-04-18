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
                    { new Guid("02d4f455-ba93-4336-8571-e1eb2fee92fd"), 7, "Jenga de mesa 54 piezas Wiss Toy", 0, "Jenga", 9900m },
                    { new Guid("07839859-d1a4-44ff-b343-0346dfa42264"), 6, "Tabla de surf 5.10 A 6.4 Stickwave", 20, "Tabla de surf", 863000m },
                    { new Guid("0b2824cf-8391-41ff-8cd1-398ffeee809d"), 2, "Impresora Multifunción HP Deskjet 2775", 10, "Impresora multifuncion", 189999m },
                    { new Guid("106f1c8b-7db0-4544-81cc-d7d3781164ca"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 17, "Heladera con freezer", 632798m },
                    { new Guid("1138ca5c-9bdf-47ca-9ee4-c3217b746b93"), 1, "Smart TV 32 pulgadas HD Android TV Admiral AD32E3A", 30, "Smart TV", 199999m },
                    { new Guid("15bb89aa-5e21-4a40-af1f-6f46b27232b1"), 3, "Cartera / Bandolera importada rígida matelasse soft cuadrado con doble broche imantado.  Manija corta fija y manija larga desmontable y regulable.", 5, "Cartera", 12500m },
                    { new Guid("190db97f-b960-4131-8f85-4eaf7dff705f"), 9, "Libro 'Netter flashcards de anatomia: miembros' de John Hansen ", 0, "Flashcards de anatomia", 40153m },
                    { new Guid("1e15d0c2-b910-46ba-9b0c-02fd53c6f541"), 5, "Suero hialuronico + niacinamida marca Libra Cosmetica", 0, "Suero hialuronico", 6752m },
                    { new Guid("1f2dcca4-2e8c-4254-8d19-2349177b5c27"), 4, "Combo 4 Silla de Comedor Eames Home", 30, "Sillas de comedor", 163017m },
                    { new Guid("272d2a15-bbec-490f-bc43-f43dd28df9ba"), 10, "Pulverizador fumigador para jardineria 2l Harden", 0, "Fumigador", 2388m },
                    { new Guid("28f5e769-b739-416d-9747-55c36627b623"), 7, "Momodisk - Juego de encastre gigante de 25 piezas", 15, "Juego de encastre", 48500m },
                    { new Guid("2c09e78a-c519-461e-ba36-904ada2ac255"), 4, "Sillón Individual escandinavo CH25 Hansen", 25, "Sillon individual", 971285m },
                    { new Guid("371bdb06-92b7-489e-a0c1-d20208ab9803"), 7, "Set policia super realista, 6 piezas  con helicoptero - 10909", 10, "Set de policia", 5520m },
                    { new Guid("38cdec18-ace9-412e-ab66-41294cb32161"), 10, "Kit de herramientas de jardineria Acero inoxidable C/bolsa", 30, "Kit de jardineria", 398689m },
                    { new Guid("38f8f4bb-fd25-46ed-bafb-cf49a185c4cc"), 2, "Celular Xiaomi Redmi Note 11 128GB Negro", 0, "Celular Xiaomi", 339999m },
                    { new Guid("391766d3-4325-445a-9b39-026ded74be4b"), 6, "Zapatillas deportivas de entrenamiento Topper Squat", 12, "Zapatillas Deportivas", 50000m },
                    { new Guid("5dde8e96-04d7-4b78-b9bc-34d318f1143a"), 10, "Kit de fabricacion de mldes de silicona AB 1:1 para bricolaje", 0, "Kit de silicona", 13886m },
                    { new Guid("5ebd65fe-f635-4871-aeab-7279c0929b06"), 8, "Leche entera larga vida Veronica Tetra x 1Lt", 0, "Leche entera", 478m },
                    { new Guid("7c2b4f7a-af1b-4639-8e5c-1fe0ff856e01"), 5, "Kit doble de limpieza para pieles grasas libra niacinamida", 0, "Kit de limpieza", 18697m },
                    { new Guid("7caf1c58-e3bd-48b0-b08f-f314a2b6b632"), 3, "Campera canguro ride", 0, "Campera", 51999m },
                    { new Guid("7d3a0085-6ed1-4a3f-9dad-7ae728134ca4"), 3, "Bufanda de lana estampada desflecada", 0, "Bufanda", 3500m },
                    { new Guid("89059776-1f9c-4796-87d9-3ae374aafa9b"), 6, "Shorts Alfest - futbol, running, basquet, gimnasio", 0, "Shorts deportivos", 4440m },
                    { new Guid("8c969cf1-1fe7-4cfb-93a7-833f91503138"), 4, "Juego de Living de 3 Sillones + Mesa Salerno", 25, "Juego de living", 2881015m },
                    { new Guid("93f16da6-b694-4816-ac62-b4e2be7f7052"), 1, "Aire acondicionado split frio/calor Carrier XPower 5120W 4400F 53HVG1801E", 0, "Aire acondicionado", 1199999m },
                    { new Guid("95c53e4a-516a-4040-919c-c0a9b0cd88eb"), 4, "Mesa de Comedor Thora", 30, "Mesa", 970697m },
                    { new Guid("9fd3b5db-52cf-4893-ab5c-22473523755c"), 3, "Buzo Anorak new fit", 45, "Buzo", 43999m },
                    { new Guid("acf8c593-e5e2-41c8-8f53-b8c717ef16d2"), 2, "Celular Samsung Galaxy A14 128GB Black", 33, "Celular Samsung", 239999m },
                    { new Guid("b38950e7-4b9d-4ab0-b3d8-1b3524cedd1c"), 8, "Pure de tomate Noel Brick x 520 Gr", 0, "Pure de tomate", 970m },
                    { new Guid("bfc2103b-35b9-4ccc-b550-e7a61361905e"), 10, "Kit de herramientas de bricolaje para el hogar 25 piezas", 15, "Kit de bricolaje", 138460m },
                    { new Guid("ca69a1e6-1ca7-41b4-b544-0d835d0eebb2"), 1, "Lavaropas carga frontal 6kg 800 RPM Drean Next 6.08 ECO", 24, "Lavaropas Carga Frontal", 669999m },
                    { new Guid("d3a10f54-d5bb-408c-9b9a-4efda318e953"), 9, "Saga de libros Dune 1-6 - Frank Herbert", 14, "Dune", 109000m },
                    { new Guid("d84e6c21-48e3-413f-b71b-7fe211b09491"), 5, "Serum bifasico revitalizante con niacinamida y agua de rosas", 0, "Serum bifasico", 5000m },
                    { new Guid("db017c55-337d-421d-b664-b5f6ecdef2a1"), 7, "Camion militar desarmable de juguete con herramientas", 0, "Camion de juguete", 2400m },
                    { new Guid("e76b68f6-306f-40fe-9c57-2d06278c5475"), 8, "Coca-Cola original, gaseosa sabor cola", 0, "Coca-Cola", 2900m },
                    { new Guid("f64d44cc-acce-4f55-bbf8-5504e54035fd"), 5, "Kit Regulacion Piel Cabelluda Mixta/grasa( Incluye Neceser + Instructivo de uso)", 13, "Kit para piel cabelluda", 36600m },
                    { new Guid("f937abb5-4360-4abc-a3b7-12438e30deee"), 8, "Jugo en polvo Arcor Naranja dulce 18 Gr", 0, "Jugo en polvo", 250m },
                    { new Guid("f97be315-939b-4334-8613-cadfc89cfa88"), 2, "Notebook Lenovo IdeaPad 1 14 pulgadas Intel Celeron 4GB 128GB SSD 82V60027AR", 14, "Notebook Lenovo", 699999m },
                    { new Guid("fb4eef76-0af4-4918-b160-1ac9c5aa451d"), 6, "Bestway 61052 bote inflable viaje/ocio", 10, "Bote inflable", 21880m },
                    { new Guid("fb67ac6b-2b6f-4dd7-82ec-4bf771b7292a"), 9, "coleccion El señor de los anillos - Tolkien - Set x 3 libros", 10, "El señor de los anillos", 39900m },
                    { new Guid("fc98de65-1b25-42a8-aae5-143a6e102def"), 9, "Libro 'Redes de computadoras' de Andrew S. Tanenbaum Nva Edicion", 0, "Redes de computadoras", 58000m }
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
