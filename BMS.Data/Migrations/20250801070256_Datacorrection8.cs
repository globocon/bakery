using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class Datacorrection8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedOn", "ImgFileExtn", "MRP", "Name", "SubCategoryId" },
                values: new object[,]
                {
                    { 116, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Irish Cake", null },
                    { 117, 13, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Ghee Cake - 2kg", null },
                    { 118, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Viva Roll", null },
                    { 119, 25, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Flower Cup", null },
                    { 120, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Marble Tray - 1kg", null },
                    { 121, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "White Tray - 1kg", null },
                    { 122, 9, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Gel - 500gm", null },
                    { 123, 16, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Baby Rusk", null },
                    { 124, 16, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Sugar Free Rusk", null },
                    { 125, 16, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Rusk Yellow", null }
                });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 84,
                column: "Name",
                value: "Meat Masala");

            migrationBuilder.InsertData(
                table: "RawMaterials",
                columns: new[] { "RawMaterialId", "CP", "CreatedById", "CreatedOn", "Name", "StockQuantity", "Unit" },
                values: new object[,]
                {
                    { 111, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Black Pepper", 0.01f, "kg" },
                    { 112, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Cake Powder", 0.01f, "kg" },
                    { 113, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Colorome", 0.01f, "kg" },
                    { 114, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Cream ", 0.01f, "kg" },
                    { 115, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Dalda", 0.01f, "kg" },
                    { 116, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Green chilly", 0.01f, "kg" },
                    { 117, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Garlic", 0.01f, "kg" },
                    { 118, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Puthina Leaves", 0.01f, "kg" },
                    { 119, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "White Elu", 0.01f, "kg" }
                });

            migrationBuilder.InsertData(
                table: "ProductRawMaterials",
                columns: new[] { "Id", "MapType", "ProductId", "QuantityRequired", "RawMaterialId", "ShowInReport" },
                values: new object[,]
                {
                    { 927, "Mix", 117, 0.4252f, 1, true },
                    { 928, "Mix", 117, 0.5512f, 2, true },
                    { 929, "Mix", 117, 0.2205f, 9, true },
                    { 930, "Mix", 117, 0.4252f, 7, true },
                    { 931, "Mix", 117, 0.018898f, 34, true },
                    { 932, "Mix", 117, 14.17323f, 6, true },
                    { 933, "Mix", 71, 0.01525424f, 112, true },
                    { 944, "Mix", 116, 0.036f, 112, true },
                    { 945, "Mix", 116, 0.004f, 1, true },
                    { 946, "Mix", 116, 0.02f, 18, true },
                    { 947, "Mix", 116, 0.004f, 35, true },
                    { 948, "Mix", 116, 0.001f, 7, true },
                    { 949, "Mix", 116, 0.001f, 9, true },
                    { 950, "Mix", 116, 0.0002f, 98, true },
                    { 951, "Mix", 116, 0.5f, 6, true },
                    { 952, "Mix", 116, 0.02f, 26, true },
                    { 953, "Mix", 118, 0.02841f, 1, true },
                    { 954, "Mix", 118, 0.02841f, 2, true },
                    { 955, "Mix", 118, 0.008523f, 17, true },
                    { 956, "Mix", 118, 0.8523f, 6, true },
                    { 957, "Mix", 118, 0.0014205f, 34, true },
                    { 958, "Mix", 118, 0.00625f, 51, true },
                    { 959, "Mix", 118, 0.0125f, 114, true },
                    { 960, "Mix", 118, 0.0025f, 9, true },
                    { 961, "Mix", 119, 0.006566f, 1, true },
                    { 962, "Mix", 119, 0.006566f, 2, true },
                    { 963, "Mix", 119, 0.0019698f, 17, true },
                    { 964, "Mix", 119, 0.19698f, 6, true },
                    { 965, "Mix", 119, 0.0003283f, 34, true },
                    { 966, "Mix", 120, 0.3334f, 1, true },
                    { 967, "Mix", 120, 0.3334f, 2, true },
                    { 968, "Mix", 120, 0.1f, 17, true },
                    { 969, "Mix", 120, 10f, 6, true },
                    { 970, "Mix", 120, 0.01667f, 34, true },
                    { 971, "Mix", 120, 0.03334f, 39, true },
                    { 972, "Mix", 121, 0.3334f, 1, true },
                    { 973, "Mix", 121, 0.3334f, 2, true },
                    { 974, "Mix", 121, 0.1f, 17, true },
                    { 975, "Mix", 121, 10f, 6, true },
                    { 976, "Mix", 121, 0.01667f, 34, true },
                    { 977, "Mix", 122, 0.1667f, 1, true },
                    { 978, "Mix", 122, 0.1667f, 2, true },
                    { 979, "Mix", 122, 0.05f, 17, true },
                    { 980, "Mix", 122, 5f, 6, true },
                    { 981, "Mix", 122, 0.00833f, 34, true },
                    { 982, "Mix", 123, 0.13043478f, 1, true },
                    { 983, "Mix", 123, 0.026086956f, 2, true },
                    { 984, "Mix", 123, 0.003261f, 15, true },
                    { 985, "Mix", 123, 0.0130435f, 24, true },
                    { 986, "Mix", 123, 0.006522f, 7, true },
                    { 987, "Mix", 123, 0.006522f, 9, true },
                    { 988, "Mix", 123, 0.0006522f, 91, true },
                    { 989, "Mix", 123, 0.0006522f, 5, true },
                    { 990, "Mix", 123, 0.00130435f, 4, true },
                    { 991, "Mix", 123, 0.001956522f, 3, true },
                    { 992, "Mix", 123, 0.086957f, 113, true },
                    { 993, "Mix", 124, 0.1875f, 1, true },
                    { 994, "Mix", 124, 0.028125f, 2, true },
                    { 995, "Mix", 124, 0.0046875f, 15, true },
                    { 996, "Mix", 124, 0.01875f, 24, true },
                    { 997, "Mix", 124, 0.01875f, 4, true },
                    { 998, "Mix", 124, 0.0009375f, 5, true },
                    { 999, "Mix", 124, 0.015625f, 90, true },
                    { 1000, "Mix", 124, 0.00046875f, 3, true },
                    { 1009, "Mix", 59, 0.015f, 115, true },
                    { 1014, "Mix", 125, 0.15f, 1, true },
                    { 1015, "Mix", 125, 0.03f, 2, true },
                    { 1016, "Mix", 125, 0.00375f, 15, true },
                    { 1017, "Mix", 125, 0.0025f, 9, true },
                    { 1018, "Mix", 125, 0.0025f, 7, true },
                    { 1019, "Mix", 125, 0.0025f, 53, true },
                    { 1020, "Mix", 125, 0.00075f, 98, true },
                    { 1021, "Mix", 125, 0.015f, 24, true },
                    { 1022, "Mix", 125, 0.0125f, 90, true },
                    { 1023, "Mix", 125, 0.00225f, 3, true },
                    { 1024, "Mix", 125, 0.0015f, 4, true },
                    { 1025, "Mix", 125, 0.00075f, 5, true },
                    { 1026, "Mix", 125, 0.00075f, 91, true },
                    { 1030, "Mix", 60, 0.0667f, 113, true },
                    { 1033, "Mix", 67, 0.0046875f, 116, true },
                    { 1034, "Mix", 67, 0.003125f, 117, true },
                    { 1037, "Mix", 67, 0.0015625f, 118, true },
                    { 1041, "Mix", 67, 0.00078125f, 119, true },
                    { 1049, "Mix", 67, 0.0015625f, 111, true }
                });

            migrationBuilder.InsertData(
                table: "ProductRawMaterials",
                columns: new[] { "Id", "MapType", "ProductId", "QuantityRequired", "RawMaterialId", "ShowInReport" },
                values: new object[,]
                {
                    { 934, "Mix", 71, 0.001695f, 1, true },
                    { 935, "Mix", 71, 0.008475f, 18, true },
                    { 936, "Mix", 71, 0.001695f, 35, true },
                    { 937, "Mix", 71, 0.000424f, 7, true },
                    { 938, "Mix", 71, 0.000424f, 9, true },
                    { 939, "Mix", 71, 8.475E-05f, 98, true },
                    { 940, "Mix", 71, 0.2119f, 6, true },
                    { 941, "Mix", 71, 0.008475f, 26, true },
                    { 942, "Mix", 71, 0.00212f, 51, true },
                    { 943, "Mix", 71, 0.00212f, 52, true },
                    { 1001, "Mix", 59, 0.15f, 1, true },
                    { 1002, "Mix", 59, 0.03f, 2, true },
                    { 1003, "Mix", 59, 0.00375f, 15, true },
                    { 1004, "Mix", 59, 0.0025f, 9, true },
                    { 1005, "Mix", 59, 0.0025f, 7, true },
                    { 1006, "Mix", 59, 0.0025f, 53, true },
                    { 1007, "Mix", 59, 0.00075f, 98, true },
                    { 1008, "Mix", 59, 0.00075f, 29, true },
                    { 1010, "Mix", 59, 0.0125f, 90, true },
                    { 1011, "Mix", 59, 0.00225f, 3, true },
                    { 1012, "Mix", 59, 0.0015f, 4, true },
                    { 1013, "Mix", 59, 0.00075f, 5, true },
                    { 1027, "Mix", 60, 0.05f, 1, true },
                    { 1028, "Mix", 60, 0.05f, 2, true },
                    { 1029, "Mix", 60, 1f, 6, true },
                    { 1031, "Mix", 67, 0.078125f, 1, true },
                    { 1032, "Mix", 67, 0.01953125f, 18, true },
                    { 1035, "Mix", 67, 0.0390625f, 24, true },
                    { 1036, "Mix", 67, 0.00625f, 83, true },
                    { 1038, "Mix", 67, 0.0015625f, 80, true },
                    { 1039, "Mix", 67, 0.00390625f, 82, true },
                    { 1040, "Mix", 67, 0.00078125f, 92, true },
                    { 1042, "Mix", 67, 0.000625f, 5, true },
                    { 1043, "Mix", 67, 0.0015625f, 4, true },
                    { 1044, "Mix", 67, 0.00203125f, 3, true },
                    { 1045, "Mix", 67, 0.0078125f, 89, true },
                    { 1046, "Mix", 67, 0.0625f, 6, true },
                    { 1047, "Mix", 67, 0.0015625f, 77, true },
                    { 1048, "Mix", 67, 0.0015625f, 84, true },
                    { 1050, "Mix", 67, 0.00234375f, 30, true },
                    { 1051, "Mix", 67, 0.015625f, 85, true },
                    { 1052, "Mix", 67, 0.0009375f, 88, true },
                    { 1053, "Mix", 66, 0.41934f, 11, true },
                    { 1054, "Mix", 66, 0.322581f, 2, true },
                    { 1055, "Mix", 66, 0.1290323f, 51, true },
                    { 1056, "Mix", 66, 0.006452f, 98, true },
                    { 1057, "Mix", 66, 5.1613f, 6, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 119);

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 84,
                column: "Name",
                value: "Meet Masala");
        }
    }
}
