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
                    { new Guid("0082469e-6f92-4139-9c30-0b3c486ea6dc"), 2, "Celular Xiaomi Redmi Note 11 128GB Negro", 0, "Celular Xiaomi", 339999m },
                    { new Guid("1207b83b-6f3d-4cc9-a3d4-d0a17ed490de"), 7, "Set policia super realista, 6 piezas  con helicoptero - 10909", 10, "Set de policia", 5520m },
                    { new Guid("34ae22ca-a950-42e8-8c2a-55733aab344b"), 10, "Kit de fabricacion de mldes de silicona AB 1:1 para bricolaje", 0, "Kit de silicona", 13886m },
                    { new Guid("377314d2-9780-41c3-907e-acc74ac35edf"), 8, "Jugo en polvo Arcor Naranja dulce 18 Gr", 0, "Jugo en polvo", 250m },
                    { new Guid("39fb84cd-fdfc-4ce8-9ae5-95f9b12e3fb9"), 10, "Kit de herramientas de bricolaje para el hogar 25 piezas", 15, "Kit de bricolaje", 138460m },
                    { new Guid("40fac4fd-909f-4061-ad7c-7ce74a9cafab"), 2, "Celular Samsung Galaxy A14 128GB Black", 33, "Celular Samsung", 239999m },
                    { new Guid("5025d569-dfa4-4699-b9bd-b10b8013788f"), 7, "Camion militar desarmable de juguete con herramientas", 0, "Camion de juguete", 2400m },
                    { new Guid("51496559-9837-4336-ac9c-e0ed009a3008"), 6, "Zapatillas deportivas de entrenamiento Topper Squat", 12, "Zapatillas Deportivas", 50000m },
                    { new Guid("55bd8d63-244b-4712-80c9-9e2da6c39516"), 4, "Mesa de Comedor Thora", 30, "Mesa", 970697m },
                    { new Guid("570bcbc5-9a90-4fbe-a97b-b68bd570cccd"), 6, "Tabla de surf 5.10 A 6.4 Stickwave", 20, "Tabla de surf", 863000m },
                    { new Guid("57bbd1e2-d068-4745-9b83-02c5a6670d66"), 5, "Serum bifasico revitalizante con niacinamida y agua de rosas", 0, "Serum bifasico", 5000m },
                    { new Guid("5bd32ad0-afdc-4166-91ce-66bfd70cde53"), 4, "Juego de Living de 3 Sillones + Mesa Salerno", 25, "Juego de living", 2881015m },
                    { new Guid("62c3041a-a7d0-4f23-86e1-550c5f504d0c"), 3, "Cartera / Bandolera importada rígida matelasse soft cuadrado con doble broche imantado.  Manija corta fija y manija larga desmontable y regulable.", 5, "Cartera", 12500m },
                    { new Guid("674ebfa7-0e26-443e-b4af-f45e5fd62f5b"), 1, "Heladera con freezer Marca Dream Hdr280f00b blanca clase A", 17, "Heladera con freezer", 632798m },
                    { new Guid("6d3007ff-32da-4b5f-b32b-b766405c12dd"), 2, "Notebook Lenovo IdeaPad 1 14 pulgadas Intel Celeron 4GB 128GB SSD 82V60027AR", 14, "Notebook Lenovo", 699999m },
                    { new Guid("6f2e5e5f-bab1-4d82-a408-fedd145a0c96"), 9, "Saga de libros Dune 1-6 - Frank Herbert", 14, "Dune", 109000m },
                    { new Guid("72945199-3f8c-4257-abab-1f01ada8d0ba"), 5, "Suero hialuronico + niacinamida marca Libra Cosmetica", 0, "Suero hialuronico", 6752m },
                    { new Guid("86326528-3e67-475d-a014-64e7f59e1a10"), 4, "Sillón Individual escandinavo CH25 Hansen", 25, "Sillon individual", 971285m },
                    { new Guid("872220da-b547-4567-bfad-0315377c18c7"), 10, "Pulverizador fumigador para jardineria 2l Harden", 0, "Fumigador", 2388m },
                    { new Guid("87b6b5dc-cca4-4ff0-ba27-fd7a2ca60f91"), 4, "Combo 4 Silla de Comedor Eames Home", 30, "Sillas de comedor", 163017m },
                    { new Guid("8d8c6de2-2c43-474b-917b-4d6e4953ac06"), 7, "Momodisk - Juego de encastre gigante de 25 piezas", 15, "Juego de encastre", 48500m },
                    { new Guid("949a745a-6aa3-4032-a1e3-4b2476fe363f"), 6, "Bestway 61052 bote inflable viaje/ocio", 10, "Bote inflable", 21880m },
                    { new Guid("a15ac31c-a7ad-42c9-87d4-7155b8f4cf4f"), 8, "Leche entera larga vida Veronica Tetra x 1Lt", 0, "Leche entera", 478m },
                    { new Guid("ab87f527-8161-4cf9-9eef-87cf760319c6"), 3, "Buzo Anorak new fit", 45, "Buzo", 43999m },
                    { new Guid("acfacd42-a98e-462a-a3a8-6fe05991cbe2"), 9, "Libro 'Redes de computadoras' de Andrew S. Tanenbaum Nva Edicion", 0, "Redes de computadoras", 58000m },
                    { new Guid("b020fa0a-5492-4ba5-ab13-f6051e24e0ba"), 10, "Kit de herramientas de jardineria Acero inoxidable C/bolsa", 30, "Kit de jardineria", 398689m },
                    { new Guid("b7eb07d1-b639-48f6-a01d-4b039fc0c3c6"), 6, "Shorts Alfest - futbol, running, basquet, gimnasio", 0, "Shorts deportivos", 4440m },
                    { new Guid("bdd61dc0-1b64-4f77-a9f1-728e9299d18a"), 9, "Libro 'Netter flashcards de anatomia: miembros' de John Hansen ", 0, "Flashcards de anatomia", 40153m },
                    { new Guid("bf17ca72-e467-49a9-8fd3-faec0be8e176"), 1, "Smart TV 32 pulgadas HD Android TV Admiral AD32E3A", 30, "Smart TV", 199999m },
                    { new Guid("c1c004c0-7fbe-4757-a3e2-c4f61f13520a"), 9, "coleccion El señor de los anillos - Tolkien - Set x 3 libros", 10, "El señor de los anillos", 39900m },
                    { new Guid("c5fe47b5-e502-46f3-a052-455bd3913f56"), 3, "Bufanda de lana estampada desflecada", 0, "Bufanda", 3500m },
                    { new Guid("ca0d9435-2f57-489b-8bff-459e6e2dc092"), 2, "Impresora Multifunción HP Deskjet 2775", 10, "Impresora multifuncion", 189999m },
                    { new Guid("cb99267a-26b1-4b9b-93ff-30bff3081808"), 8, "Coca-Cola original, gaseosa sabor cola", 0, "Coca-Cola", 2900m },
                    { new Guid("d97fe8a2-1d6f-4ea3-ad45-c39f3f90cfa0"), 8, "Pure de tomate Noel Brick x 520 Gr", 0, "Pure de tomate", 970m },
                    { new Guid("e13e16ef-b638-40d1-bbad-36048bdf905e"), 5, "Kit doble de limpieza para pieles grasas libra niacinamida", 0, "Kit de limpieza", 18697m },
                    { new Guid("e1c3a8b7-e1a3-47f0-a576-0e9cf84c7212"), 1, "Aire acondicionado split frio/calor Carrier XPower 5120W 4400F 53HVG1801E", 0, "Aire acondicionado", 1199999m },
                    { new Guid("e4e16bd1-3ab6-4871-8c52-fe6b4ca24c24"), 5, "Kit Regulacion Piel Cabelluda Mixta/grasa( Incluye Neceser + Instructivo de uso)", 13, "Kit para piel cabelluda", 36600m },
                    { new Guid("f6ef8035-7b6e-4c35-a472-6d7938e20ef9"), 1, "Lavaropas carga frontal 6kg 800 RPM Drean Next 6.08 ECO", 24, "Lavaropas Carga Frontal", 669999m },
                    { new Guid("f7fe379d-aea7-4489-a7c4-e15ae403b793"), 3, "Campera canguro ride", 0, "Campera", 51999m },
                    { new Guid("fcb507a7-2906-4d12-8661-603ff39121d8"), 7, "Jenga de mesa 54 piezas Wiss Toy", 0, "Jenga", 9900m }
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
