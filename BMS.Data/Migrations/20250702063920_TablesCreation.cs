using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class TablesCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "USR_Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "ImgFileExtn",
                table: "USR_Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GSTNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgFileExtn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "PreparationTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreparationTeams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    RawMaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockQuantity = table.Column<float>(type: "real", nullable: false, defaultValue: 0f),
                    CP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.RawMaterialId);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    InvoiceRefId = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Pending"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreparationTeamId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_PreparationTeams_PreparationTeamId",
                        column: x => x.PreparationTeamId,
                        principalTable: "PreparationTeams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MRP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImgFileExtn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SubCategory_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DeliveryDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductRawMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    RawMaterialId = table.Column<int>(type: "int", nullable: false),
                    QuantityRequired = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRawMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductRawMaterials_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductRawMaterials_RawMaterials_RawMaterialId",
                        column: x => x.RawMaterialId,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CreatedById", "CreatedOn", "Email", "GSTNo", "ImgFileExtn", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "123 Main Street", "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, "32GST1AC23452Z2", null, "Hotel Margretta", "1234567890" },
                    { 2, "CC Road", "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, "32GSE2AC23462Z2", null, "Moon Bakery", null },
                    { 3, "45 Second Street", "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, null, null, "Best Bakery", null },
                    { 4, "Grand Street", "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, null, null, "Hotel Grand", null },
                    { 5, "Roastown Street", "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, null, null, "Roastown Grill", null },
                    { 6, "Paragon Main Street", "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, null, null, "Fort Paragon", null },
                    { 7, "123 House Street", "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, null, null, "Ginger House", null },
                    { 8, "Fort Kochi", "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, null, null, "Rasoi Fort Kochi", null }
                });

            migrationBuilder.InsertData(
                table: "PreparationTeams",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "TeamName" },
                values: new object[,]
                {
                    { 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Fast Food Team" },
                    { 2, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Nadan Items Team" }
                });

            migrationBuilder.InsertData(
                table: "RawMaterials",
                columns: new[] { "RawMaterialId", "CP", "CreatedById", "CreatedOn", "Name", "StockQuantity", "Unit" },
                values: new object[,]
                {
                    { 1, 36m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Maida", 295.9f, "kg" },
                    { 2, 39m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Sugar", 75.7f, "kg" },
                    { 3, 9m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Salt", 100f, "kg" },
                    { 4, 315m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Milk Powder", 0.88f, "kg" },
                    { 5, 312m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Vanila Powder", 1.9f, "kg" },
                    { 6, 5m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Egg", 699f, "kg" },
                    { 7, 550m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "RKG", 2.79f, "kg" },
                    { 8, 85m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Custard Powder", 0.55f, "kg" },
                    { 9, 256m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Milkmaid", 6.76f, "kg" },
                    { 10, 500m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Nuts", 1.05f, "kg" },
                    { 11, 210m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Coconut Powder", 2.645f, "kg" },
                    { 12, 465m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Butter", 1.89f, "kg" },
                    { 13, 190m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Bread Improver", 0.75f, "kg" },
                    { 14, 85m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Baking Powder", 0.95f, "kg" },
                    { 15, 145m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Yeast", 1.96f, "kg" },
                    { 16, 155m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Sunflower Oil", 4.55f, "kg" },
                    { 17, 185m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Coconut Oil", 1.84f, "kg" },
                    { 18, 70m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Icing Sugar", 10f, "kg" },
                    { 19, 1320m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Cardamom", 0.24f, "kg" },
                    { 20, 60m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Atta", 1.36f, "kg" },
                    { 21, 45m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Aval", 6.96f, "kg" },
                    { 22, 159m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Lilly - Puffs", 19.7f, "kg" },
                    { 23, 148m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Sheel - Bread", 8.09f, "kg" },
                    { 24, 163m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Biskin - Cookies", 10f, "kg" },
                    { 25, 170m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "SSM - Cream", 19.7f, "kg" },
                    { 26, 168m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "USM - Cake", 9.83f, "kg" },
                    { 27, 260m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Dark Chocolate", 0.88f, "kg" },
                    { 28, 364m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "WhiteChocolate", 0.56f, "kg" },
                    { 29, 500m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Garam Masala", 0.15f, "kg" },
                    { 30, 240m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Ginger Powder", 100f, "kg" },
                    { 31, 180m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Jeerakam", 0.565f, "kg" },
                    { 32, 190m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Sadu Jeerakam", 100f, "kg" },
                    { 33, 50m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Soda Powder", 0.305f, "kg" },
                    { 34, 220m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Gel", 0.15f, "kg" },
                    { 35, 75m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Jam Mixed", 3.74f, "kg" },
                    { 36, 75m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Jam Pineapple", 4.4f, "kg" },
                    { 37, 85m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Liquid Glucose", 1.06f, "kg" },
                    { 38, 110m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Jue Colour", 0.445f, "kg" },
                    { 39, 360m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Coco Powder", 100f, "kg" },
                    { 40, 250m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Calcium", 0.385f, "kg" },
                    { 41, 180m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Jelly White", 0.04f, "kg" },
                    { 42, 185m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Jelly Black", 0.095f, "kg" },
                    { 43, 129m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Palm Oil", 100f, "kg" },
                    { 44, 51m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Sarkara", 23f, "kg" },
                    { 45, 105m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Cut Dates", 6.6f, "kg" },
                    { 46, 110m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Candy Peel", 100f, "kg" },
                    { 47, 260m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Ginger Peel", 100f, "kg" },
                    { 48, 39m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Orange", 100f, "kg" },
                    { 49, 100m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Makkiri", 100f, "kg" },
                    { 50, 100m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Naranga/Lemon", 100f, "kg" },
                    { 51, 56m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Tuty", 2.4f, "kg" },
                    { 52, 220m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Cherry", 1.46f, "kg" },
                    { 53, 138m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Kismiss", 300f, "kg" },
                    { 54, 175m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Pineapple cutting", 1.09f, "kg" },
                    { 55, 120m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Black Forest Powder", 7f, "kg" },
                    { 56, 102m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "White Forest Powder", 3.36f, "kg" },
                    { 57, 210m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Red Velvet", 5.4f, "kg" },
                    { 58, 420m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Vanila", 20f, "kg" },
                    { 59, 480m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Orange", 20f, "kg" },
                    { 60, 431m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Pineapple", 20f, "kg" },
                    { 61, 400m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Ice Cream", 20f, "kg" },
                    { 62, 356m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Lemon", 20f, "kg" },
                    { 63, 440m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Rum", 20f, "kg" },
                    { 64, 300m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Almond", 20f, "kg" },
                    { 65, 1360m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Plum", 20f, "kg" },
                    { 66, 220m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Butter", 20f, "kg" },
                    { 67, 500m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Banana", 20f, "kg" },
                    { 68, 2m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Water", 20f, "kg" },
                    { 69, 5m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Pista Nuts", 20f, "kg" },
                    { 70, 200m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Muffin Mix Vanila", 20f, "kg" },
                    { 71, 250m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Muffin Mix Choc", 20f, "kg" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "Name", "PreparationTeamId" },
                values: new object[,]
                {
                    { 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Puffs_Sweetna", 1 },
                    { 2, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Bread_Bun", 1 },
                    { 3, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Fruit_ButterBread_Donut", 1 },
                    { 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Tea_Cake", 1 },
                    { 5, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Plum_Cake", 1 },
                    { 6, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Pineapple_Cake", 1 },
                    { 7, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Carrot_Dates_Cake", 1 },
                    { 8, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Spunge_Cake", 1 },
                    { 9, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Cream", 1 },
                    { 10, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Black_Forest", 1 },
                    { 11, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "White_Forest", 1 },
                    { 12, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Red_Velvet", 1 },
                    { 13, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Ghee_Cake", 1 },
                    { 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Sandwitch_Pizza", 1 },
                    { 15, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Tea_Rusk", 1 },
                    { 16, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "White_Rusk", 1 },
                    { 17, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Beans_Biscuit", 1 },
                    { 18, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Pineapple_Cookies", 1 },
                    { 19, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Orange_Cookies", 1 },
                    { 20, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Strawberry_Cookies", 1 },
                    { 21, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Pista_Cookies", 1 },
                    { 22, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Semia_Cookies", 1 },
                    { 23, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Coconut_Cookies", 1 },
                    { 24, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Masala_Cookies", 1 },
                    { 25, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Muffins", 1 },
                    { 26, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Choc Muffin", 1 },
                    { 27, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Cherry Cake", 1 },
                    { 28, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Samosa", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedOn", "ImgFileExtn", "MRP", "Name", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "SWEETNA", null },
                    { 2, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "SWEET STICK", null },
                    { 3, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "KARI", null },
                    { 4, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "DILPASANTH", null },
                    { 5, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "CREAM CORN", null },
                    { 11, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Neyyappam", null },
                    { 12, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Kubalappam", null },
                    { 13, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Kozhakatta", null },
                    { 14, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Elayappam", null },
                    { 15, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Sugiyan", null },
                    { 16, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Uzhunnuvada", null },
                    { 17, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Parippuvada", null },
                    { 18, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Pazhampori", null },
                    { 23, 2, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "BREAD", null },
                    { 24, 2, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "BUN", null },
                    { 25, 2, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "AVAL BUN", null },
                    { 26, 2, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "CREAM BUN", null },
                    { 27, 3, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "FRUIT BREAD", null },
                    { 28, 3, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "BUTTER BREAD", null },
                    { 29, 3, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "DONUT", null },
                    { 34, 5, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "PLUM CAKE", null },
                    { 35, 6, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "PINEAPPALE CAKE", null },
                    { 36, 7, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "CARROT&DATES CAKE", null },
                    { 37, 9, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Cream", null },
                    { 38, 8, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "SPUNGE CAKE", null },
                    { 39, 10, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Black Forest Cake", null },
                    { 40, 11, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "White Forest Cake", null },
                    { 41, 12, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Red Velvet Cake", null },
                    { 42, 13, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "GHEE CAKE", null },
                    { 43, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Sandwitch BREAD", null },
                    { 44, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "ATTA BREAD", null },
                    { 45, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "PAV BUN", null },
                    { 46, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Kubboos", null },
                    { 47, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Chicken Roll", null },
                    { 48, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Meat Roll", null },
                    { 49, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Veg Roll", null },
                    { 54, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Chicken Pizza", null },
                    { 55, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Chicken Burger", null },
                    { 56, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Meat Burger", null },
                    { 57, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Veg Burger", null },
                    { 58, 15, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "TEA RUSK", null },
                    { 59, 16, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "WHITE RUSK", null },
                    { 60, 17, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Beans Biscuit", null },
                    { 61, 18, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Pineapple Cookies", null },
                    { 62, 19, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Orange Cookies", null },
                    { 63, 20, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Strawberry Cookies", null },
                    { 64, 21, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Pista Cookies", null },
                    { 65, 22, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Semia Cookies", null },
                    { 66, 23, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Coconut Cookies", null },
                    { 67, 24, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Masala Cookies", null },
                    { 68, 25, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Pineapple Muffin", null },
                    { 69, 25, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Strwberry Muffin", null },
                    { 70, 26, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Choc Muffin", null },
                    { 71, 27, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Cherry Cake", null }
                });

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "PUFFS" },
                    { 2, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "TEA CAKE" },
                    { 3, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "SANDWICH" },
                    { 4, 27, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "SAMOSA" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedOn", "ImgFileExtn", "MRP", "Name", "SubCategoryId" },
                values: new object[,]
                {
                    { 6, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Egg Puffs", 1 },
                    { 7, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Chicken Puffs", 1 },
                    { 8, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Meat Puffs", 1 },
                    { 9, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Banana Puffs", 1 },
                    { 10, 1, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Veg Puffs", 1 },
                    { 19, 27, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Veg Samosa", 4 },
                    { 20, 27, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Egg Samosa", 4 },
                    { 21, 27, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Meat Samosa", 4 },
                    { 22, 27, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Chicken Samosa", 4 },
                    { 30, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Marble Cake", 2 },
                    { 31, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Tea Cake", 2 },
                    { 32, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Butter Plum", 2 },
                    { 33, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Strawberry Cake", 2 },
                    { 50, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Chicken sandwitch", 3 },
                    { 51, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Meat sandwitch", 3 },
                    { 52, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Veg sandwitch", 3 },
                    { 53, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Chicken Tikka", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PreparationTeamId",
                table: "Categories",
                column: "PreparationTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_ProductId",
                table: "InvoiceItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRawMaterials_ProductId",
                table: "ProductRawMaterials",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRawMaterials_RawMaterialId",
                table: "ProductRawMaterials",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductRawMaterials");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "PreparationTeams");

            migrationBuilder.DropColumn(
                name: "ImgFileExtn",
                table: "USR_Users");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "USR_Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);
        }
    }
}
