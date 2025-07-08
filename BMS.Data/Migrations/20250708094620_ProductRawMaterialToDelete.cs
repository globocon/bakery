using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductRawMaterialToDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductRawMaterials",
                columns: new[] { "Id", "ProductId", "QuantityRequired", "RawMaterialId" },
                values: new object[,]
                {
                    { 1, 1, 0.042857f, 1 },
                    { 2, 2, 0.0375f, 1 },
                    { 3, 3, 0.12f, 1 },
                    { 4, 4, 0.125f, 1 },
                    { 5, 5, 0.04f, 1 },
                    { 6, 6, 0.034f, 1 },
                    { 7, 7, 0.035f, 1 },
                    { 8, 8, 0.034f, 1 },
                    { 9, 9, 0.034f, 1 },
                    { 10, 10, 0.034f, 1 },
                    { 11, 1, 0.024857f, 22 },
                    { 12, 2, 0.02175f, 22 },
                    { 13, 3, 0.0696f, 22 },
                    { 14, 4, 0.0725f, 22 },
                    { 15, 5, 0.0232f, 22 },
                    { 16, 6, 0.01972f, 22 },
                    { 17, 7, 0.0203f, 22 },
                    { 18, 8, 0.01972f, 22 },
                    { 19, 9, 0.01972f, 22 },
                    { 20, 10, 0.01972f, 22 },
                    { 21, 1, 0.000857f, 3 },
                    { 22, 2, 0.00075f, 3 },
                    { 23, 3, 0.0024f, 3 },
                    { 24, 4, 0.0025f, 3 },
                    { 25, 5, 0.0008f, 3 },
                    { 26, 6, 0.00068f, 3 },
                    { 27, 7, 0.0007f, 3 },
                    { 28, 8, 0.00068f, 3 },
                    { 29, 9, 0.00068f, 3 },
                    { 30, 10, 0.00068f, 3 },
                    { 31, 1, 0.002143f, 2 },
                    { 32, 2, 0.001875f, 2 },
                    { 33, 3, 0.006f, 2 },
                    { 34, 4, 0.00625f, 2 },
                    { 35, 5, 0.002f, 2 },
                    { 36, 6, 0.0017f, 2 },
                    { 37, 7, 0.00175f, 2 },
                    { 38, 8, 0.0017f, 2 },
                    { 39, 9, 0.0017f, 2 },
                    { 40, 10, 0.0017f, 2 },
                    { 41, 1, 0.042857f, 6 },
                    { 42, 2, 0.0375f, 6 },
                    { 43, 3, 0.12f, 6 },
                    { 44, 4, 0.125f, 6 },
                    { 45, 5, 0.04f, 6 },
                    { 46, 6, 0.534f, 6 },
                    { 47, 7, 0.034f, 6 },
                    { 48, 8, 0.034f, 6 },
                    { 49, 9, 0.034f, 6 },
                    { 50, 10, 0.034f, 6 },
                    { 51, 1, 0.000214f, 5 },
                    { 52, 2, 0.000188f, 5 },
                    { 53, 3, 0.0006f, 5 },
                    { 54, 4, 0.000625f, 5 },
                    { 55, 5, 0.0002f, 5 },
                    { 56, 6, 0.00017f, 5 },
                    { 57, 7, 0.000175f, 5 },
                    { 58, 8, 0.00017f, 5 },
                    { 59, 9, 0.00017f, 5 },
                    { 60, 10, 0.00017f, 5 },
                    { 61, 1, 0.000429f, 4 },
                    { 62, 2, 0.000375f, 4 },
                    { 63, 3, 0.0012f, 4 },
                    { 64, 4, 0.00125f, 4 },
                    { 65, 5, 0.0004f, 4 },
                    { 66, 6, 0.00034f, 4 },
                    { 67, 7, 0.00035f, 4 },
                    { 68, 8, 0.00034f, 4 },
                    { 69, 9, 0.00034f, 4 },
                    { 70, 10, 0.00034f, 4 },
                    { 71, 1, 0.01f, 51 },
                    { 72, 2, 0.005625f, 51 },
                    { 73, 4, 0.0125f, 51 },
                    { 74, 5, 0.01f, 51 },
                    { 75, 1, 0.016f, 18 },
                    { 76, 2, 0.00675f, 18 },
                    { 77, 4, 0.015f, 18 },
                    { 78, 5, 0.016f, 18 },
                    { 79, 1, 0.001286f, 19 },
                    { 80, 2, 0.000938f, 19 },
                    { 81, 4, 0.001875f, 19 },
                    { 82, 5, 0.0003f, 19 },
                    { 83, 2, 0.002063f, 52 },
                    { 84, 4, 0.005f, 52 },
                    { 85, 2, 0.001688f, 7 },
                    { 86, 4, 0.00375f, 7 },
                    { 87, 2, 0.0105f, 21 },
                    { 88, 4, 0.025f, 21 },
                    { 89, 2, 0.001688f, 8 },
                    { 90, 4, 0.00375f, 8 },
                    { 91, 2, 0.002813f, 9 },
                    { 92, 4, 0.00625f, 9 },
                    { 93, 2, 0.0015f, 10 },
                    { 94, 4, 0.003125f, 10 },
                    { 95, 2, 0.0225f, 11 },
                    { 96, 4, 0.075f, 11 },
                    { 97, 7, 0.012f, 72 },
                    { 98, 8, 0.012f, 73 }
                });
           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 98);
        }
    }
}
