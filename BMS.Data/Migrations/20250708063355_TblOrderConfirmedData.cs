using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class TblOrderConfirmedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderConfirmData",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductMRP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImgFileExtn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductOrderQuantity = table.Column<int>(type: "int", nullable: false),
                    OrderDeliveryDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RawMaterialId = table.Column<int>(type: "int", nullable: false),
                    RawMaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RawMaterialStockQuantity = table.Column<float>(type: "real", nullable: false),
                    RawMaterialRequiredQuantity = table.Column<float>(type: "real", nullable: false),
                    RawMaterialCP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RawMaterialUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderConfirmData", x => x.ReportId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderConfirmData");
        }
    }
}
