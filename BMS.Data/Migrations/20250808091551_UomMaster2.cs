using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class UomMaster2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Update Products SET UOM = 'Nos', Sort_Order = 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
