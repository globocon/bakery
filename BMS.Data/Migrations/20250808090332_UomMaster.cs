using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class UomMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sort_Order",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UOM",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<float>(
                name: "Quantity",
                table: "OrderItems",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "ProductOrderQuantity",
                table: "OrderConfirmData",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ProductUom",
                table: "OrderConfirmData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<float>(
                name: "Quantity",
                table: "InvoiceItems",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "UomMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UOMName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UomMaster", x => x.Id);
                });


            migrationBuilder.Sql("Update Products SET UOM = 'Nos', Sort_Order = 0");
            migrationBuilder.Sql("INSERT INTO UomMaster (UOMName) VALUES ('Nos'), ('Kg'), ('ltr')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UomMaster");

            migrationBuilder.DropColumn(
                name: "Sort_Order",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UOM",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductUom",
                table: "OrderConfirmData");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "OrderItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "ProductOrderQuantity",
                table: "OrderConfirmData",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "InvoiceItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
