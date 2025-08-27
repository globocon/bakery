using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class CatogerySortOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorySortOrder",
                table: "OrderConfirmData",
                type: "int",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.Sql("UPDATE [OrderConfirmData] SET CategorySortOrder=0");
            migrationBuilder.Sql("INSERT INTO [TranHist] ([CreatedOn],[TranTypeId],[Quantity],[CP],[Unit],[CreatedById]) SELECT [CreatedOn],1,[StockQuantity],[CP],[Unit],'System' FROM [RawMaterials]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategorySortOrder",
                table: "OrderConfirmData");
        }
    }
}
