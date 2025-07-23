using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataCorrection06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("DELETE FROM Orders");
            migrationBuilder.Sql("DELETE FROM OrderConfirmData");
            migrationBuilder.Sql("DELETE FROM Invoices");

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

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "ProductRawMaterials",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Marble Cake - Tray");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Tea Cake - Tray");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Butter Plum - Tray");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Strawberry Cake - Tray");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Pineapple Cake - Tray");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "Kuboose Single");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedById", "CreatedOn", "ImgFileExtn", "MRP", "Name", "SubCategoryId" },
                values: new object[,]
                {
                    { 94, 2, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Bun Single", null },
                    { 95, 2, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Bun 1 packet (4nos)", null },
                    { 96, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Marble Cake - 800gm", null },
                    { 97, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Marble Cake - 400gm", null },
                    { 98, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Tea Cake - 800gm", null },
                    { 99, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Tea Cake - 400gm", null },
                    { 100, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Strawberry Cake - 800gm", null },
                    { 101, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Strawberry Cake - 400gm", null },
                    { 102, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Butter Plum - 800gm", null },
                    { 103, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Butter Plum - 400gm", null },
                    { 104, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Pineapple Cake - 800gm", null },
                    { 105, 4, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Pineapple Cake - 400gm", null },
                    { 106, 2, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Wheat Bread", null },
                    { 107, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Kuboose 1 packet ", null },
                    { 108, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Tikka Chicken", null },
                    { 109, 14, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Pizza", null },
                    { 110, 25, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "White Cup", null },
                    { 111, 25, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Pineapple Cup", null },
                    { 112, 25, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Pineapple Muffin Cup", null },
                    { 113, 25, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Strawberry Muffin Cup", null },
                    { 114, 25, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Orange Muffin Cup", null },
                    { 115, 25, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), null, 450m, "Mango Muffin Cup", null }
                });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 28,
                column: "Name",
                value: "White Chocolate");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 58,
                column: "Name",
                value: "Vanila Essence");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 62,
                column: "Name",
                value: "Lemon Essence");

            migrationBuilder.InsertData(
                table: "RawMaterials",
                columns: new[] { "RawMaterialId", "CP", "CreatedById", "CreatedOn", "Name", "StockQuantity", "Unit" },
                values: new object[,]
                {
                    { 93, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Almond Essence", 0.01f, "kg" },
                    { 94, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Colorome mango", 0.01f, "kg" },
                    { 95, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Colorome orange", 0.01f, "kg" },
                    { 96, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Colorome strawberry", 0.01f, "kg" },
                    { 97, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Dark bar", 0.01f, "kg" },
                    { 98, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Elachi", 0.01f, "kg" },
                    { 99, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Fresh Coconut", 0.01f, "kg" },
                    { 100, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Ice cream Essence", 0.01f, "kg" },
                    { 101, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Muffin Mix", 0.01f, "kg" },
                    { 102, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Natural color pine", 0.01f, "kg" },
                    { 103, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Pineapple Colorme", 0.01f, "kg" },
                    { 104, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Pineapple Essence", 0.01f, "kg" },
                    { 105, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Pista Colorme", 0.01f, "kg" },
                    { 106, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Plum Essence", 0.01f, "kg" },
                    { 107, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Rum Essence", 0.01f, "kg" },
                    { 108, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Semia", 0.01f, "kg" },
                    { 109, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "Strawberry Colorme", 0.01f, "kg" },
                    { 110, 1m, "Initial Creation", new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602), "White bar", 0.01f, "kg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 110);

            migrationBuilder.InsertData(
                table: "ProductRawMaterials",
                columns: new[] { "Id", "MapType", "ProductId", "QuantityRequired", "RawMaterialId", "ShowInReport" },
                values: new object[,]
                {
                    { 1, "Mix", 6, 0.528f, 6, true },
                    { 2, "Mix", 6, 0.029f, 1, true },
                    { 3, "Mix", 6, 0.0157f, 22, true },
                    { 4, "Mix", 6, 0.00057f, 3, true },
                    { 5, "Mix", 6, 0.0014f, 2, true },
                    { 6, "Mix", 6, 0.00014f, 5, true },
                    { 7, "Mix", 6, 0.00028f, 4, true },
                    { 8, "Masala", 6, 0.03f, 85, false },
                    { 9, "Masala", 6, 0.003f, 82, false },
                    { 10, "Masala", 6, 0.001f, 79, false },
                    { 11, "Masala", 6, 0.001f, 88, false },
                    { 12, "Masala", 6, 0.0005f, 84, false },
                    { 13, "Masala", 6, 0.0005f, 77, false },
                    { 14, "Masala", 6, 0.0005f, 29, false },
                    { 15, "Masala", 6, 0.0005f, 78, false },
                    { 16, "Masala", 6, 0.004f, 17, false },
                    { 17, "Mix", 8, 0.028f, 6, true },
                    { 18, "Mix", 8, 0.029f, 1, true },
                    { 19, "Mix", 8, 0.0157f, 22, true },
                    { 20, "Mix", 8, 0.00057f, 3, true },
                    { 21, "Mix", 8, 0.0014f, 2, true },
                    { 22, "Mix", 8, 0.00014f, 5, true },
                    { 23, "Mix", 8, 0.00028f, 4, true },
                    { 24, "Masala", 8, 0.03f, 85, false },
                    { 25, "Masala", 8, 0.003f, 82, false },
                    { 26, "Masala", 8, 0.001f, 79, false },
                    { 27, "Masala", 8, 0.001f, 88, false },
                    { 28, "Masala", 8, 0.0005f, 84, false },
                    { 29, "Masala", 8, 0.0005f, 77, false },
                    { 30, "Masala", 8, 0.0005f, 29, false },
                    { 31, "Masala", 8, 0.0005f, 78, false },
                    { 32, "Masala", 8, 0.004f, 17, false },
                    { 33, "Masala", 8, 0.01f, 73, false },
                    { 34, "Mix", 10, 0.028f, 6, true },
                    { 35, "Mix", 10, 0.029f, 1, true },
                    { 36, "Mix", 10, 0.0157f, 22, true },
                    { 37, "Mix", 10, 0.00057f, 3, true },
                    { 38, "Mix", 10, 0.0014f, 2, true },
                    { 39, "Mix", 10, 0.00014f, 5, true },
                    { 40, "Mix", 10, 0.00028f, 4, true },
                    { 41, "Masala", 10, 0.001f, 88, false },
                    { 42, "Masala", 10, 0.0002f, 84, false },
                    { 43, "Masala", 10, 0.0002f, 77, false },
                    { 44, "Masala", 10, 0.0003f, 29, false },
                    { 45, "Masala", 10, 0.0005f, 78, false },
                    { 46, "Masala", 10, 0.004f, 17, false },
                    { 47, "Masala", 10, 0.019f, 86, false },
                    { 48, "Masala", 10, 0.0067f, 75, false },
                    { 49, "Masala", 10, 0.0019f, 66, false },
                    { 50, "Masala", 10, 0.001f, 74, false },
                    { 51, "Masala", 10, 0.002f, 87, false },
                    { 52, "Masala", 10, 0.0005f, 79, false },
                    { 53, "Masala", 10, 0.005f, 85, false },
                    { 54, "Masala", 10, 0.0005f, 82, false },
                    { 55, "Masala", 10, 0.0002f, 83, false },
                    { 56, "Masala", 10, 0.0002f, 80, false },
                    { 57, "Mix", 7, 0.028f, 6, true },
                    { 58, "Mix", 7, 0.0316f, 1, true },
                    { 59, "Mix", 7, 0.0173f, 22, true },
                    { 60, "Mix", 7, 0.0002f, 3, true },
                    { 61, "Mix", 7, 0.00052f, 2, true },
                    { 62, "Mix", 7, 0.00052f, 5, true },
                    { 63, "Mix", 7, 0.0001f, 4, true },
                    { 64, "Masala", 7, 0.03f, 85, false },
                    { 65, "Masala", 7, 0.003f, 82, false },
                    { 66, "Masala", 7, 0.001f, 79, false },
                    { 67, "Masala", 7, 0.001f, 88, false },
                    { 68, "Masala", 7, 0.0005f, 84, false },
                    { 69, "Masala", 7, 0.0005f, 77, false },
                    { 70, "Masala", 7, 0.0005f, 29, false },
                    { 71, "Masala", 7, 0.0005f, 78, false },
                    { 72, "Masala", 7, 0.004f, 17, false },
                    { 73, "Masala", 7, 0.01f, 72, false },
                    { 74, "Mix", 9, 0.028f, 6, true },
                    { 75, "Mix", 9, 0.029f, 1, true },
                    { 76, "Mix", 9, 0.0157f, 22, true },
                    { 77, "Mix", 9, 0.00057f, 3, true },
                    { 78, "Mix", 9, 0.0014f, 2, true },
                    { 79, "Mix", 9, 0.00014f, 5, true },
                    { 80, "Mix", 9, 0.00028f, 4, true },
                    { 81, "Masala", 9, 0.0009f, 68, true },
                    { 82, "Masala", 9, 0.0006f, 9, true },
                    { 83, "Masala", 9, 0.0006f, 7, true },
                    { 84, "Masala", 9, 0.0595f, 19, true },
                    { 85, "Masala", 9, 0.001f, 51, true },
                    { 86, "Masala", 9, 0.0015f, 11, true },
                    { 87, "Masala", 9, 0.006f, 2, true },
                    { 88, "Masala", 9, 0.0005f, 10, true },
                    { 89, "Masala", 9, 0.0009f, 52, true },
                    { 90, "Masala", 9, 0.001f, 53, true },
                    { 91, "Masala", 9, 0.003f, 21, true },
                    { 92, "Masala", 9, 0.025f, 67, true },
                    { 93, "Mix", 1, 0.0375f, 1, true },
                    { 94, "Mix", 1, 0.0206f, 22, true },
                    { 95, "Mix", 1, 0.00025f, 3, true },
                    { 96, "Mix", 1, 0.0006f, 2, true },
                    { 97, "Mix", 1, 0.0375f, 6, true },
                    { 98, "Mix", 1, 0.00018f, 5, true },
                    { 99, "Mix", 1, 0.00038f, 4, true },
                    { 100, "Masala", 1, 0.0006f, 53, true },
                    { 101, "Masala", 1, 0.001f, 8, true },
                    { 102, "Masala", 1, 0.00025f, 19, true },
                    { 103, "Masala", 1, 0.00025f, 5, true },
                    { 104, "Masala", 1, 0.01f, 2, true },
                    { 105, "Mix", 2, 0.0285f, 6, true },
                    { 106, "Mix", 2, 0.0285f, 1, true },
                    { 107, "Mix", 2, 0.0157f, 22, true },
                    { 108, "Mix", 2, 0.00057f, 3, true },
                    { 109, "Mix", 2, 0.0014f, 2, true },
                    { 110, "Mix", 2, 0.00014f, 5, true },
                    { 111, "Mix", 2, 0.000285f, 4, true },
                    { 112, "Masala", 2, 0.0023f, 68, true },
                    { 113, "Masala", 2, 0.0022f, 9, true },
                    { 114, "Masala", 2, 0.0022f, 7, true },
                    { 115, "Masala", 2, 0.0017f, 19, true },
                    { 116, "Masala", 2, 0.0056f, 51, true },
                    { 117, "Masala", 2, 0.0111f, 11, true },
                    { 118, "Masala", 2, 0.016f, 2, true },
                    { 119, "Masala", 2, 0.0033f, 10, true },
                    { 120, "Masala", 2, 0.013f, 52, true },
                    { 121, "Masala", 2, 0.00298f, 53, true },
                    { 122, "Masala", 2, 0.008f, 21, true },
                    { 123, "Masala", 2, 0.0034f, 8, true },
                    { 124, "Mix", 3, 0.125f, 1, true },
                    { 125, "Mix", 3, 0.0687f, 22, true },
                    { 126, "Mix", 3, 0.0025f, 3, true },
                    { 127, "Mix", 3, 0.00625f, 2, true },
                    { 128, "Mix", 3, 0.125f, 6, true },
                    { 129, "Mix", 3, 0.00063f, 5, true },
                    { 130, "Mix", 3, 0.00125f, 4, true },
                    { 131, "Mix", 4, 0.0285f, 6, true },
                    { 132, "Mix", 4, 0.0285f, 1, true },
                    { 133, "Mix", 4, 0.0157f, 22, true },
                    { 134, "Mix", 4, 0.00057f, 3, true },
                    { 135, "Mix", 4, 0.0014f, 2, true },
                    { 136, "Mix", 4, 0.00014f, 5, true },
                    { 137, "Mix", 4, 0.000285f, 4, true },
                    { 138, "Masala", 4, 0.062f, 11, true },
                    { 139, "Masala", 4, 0.026f, 2, true },
                    { 140, "Masala", 4, 0.001f, 19, true },
                    { 141, "Masala", 4, 0.021f, 51, true },
                    { 142, "Masala", 4, 0.01f, 53, true },
                    { 143, "Masala", 4, 0.0052f, 9, true },
                    { 144, "Masala", 4, 0.0052f, 7, true },
                    { 145, "Masala", 4, 0.005f, 52, true },
                    { 146, "Masala", 4, 0.005f, 8, true },
                    { 147, "Masala", 4, 0.0052f, 76, true },
                    { 148, "Mix", 5, 0.04f, 6, true },
                    { 149, "Mix", 5, 0.04f, 1, true },
                    { 150, "Mix", 5, 0.022f, 22, true },
                    { 151, "Mix", 5, 0.008f, 3, true },
                    { 152, "Mix", 5, 0.002f, 2, true },
                    { 153, "Mix", 5, 0.0002f, 5, true },
                    { 154, "Mix", 5, 0.004f, 4, true },
                    { 155, "Mix", 23, 0.225f, 1, true },
                    { 156, "Mix", 23, 0.023f, 23, true },
                    { 157, "Mix", 23, 0.0034f, 3, true },
                    { 158, "Mix", 23, 0.0563f, 2, true },
                    { 159, "Mix", 23, 0.0011f, 5, true },
                    { 160, "Mix", 23, 0.0023f, 4, true },
                    { 161, "Mix", 23, 0.00113f, 7, true },
                    { 162, "Mix", 23, 0.00113f, 12, true },
                    { 163, "Mix", 23, 0.00113f, 9, true },
                    { 164, "Mix", 23, 0.0063f, 15, true },
                    { 165, "Mix", 23, 0.002f, 16, true },
                    { 166, "Mix", 24, 0.028f, 1, true },
                    { 167, "Mix", 24, 0.0028f, 23, true },
                    { 168, "Mix", 24, 0.0004f, 3, true },
                    { 169, "Mix", 24, 0.0069f, 2, true },
                    { 170, "Mix", 24, 0.00014f, 5, true },
                    { 171, "Mix", 24, 0.00028f, 4, true },
                    { 172, "Mix", 24, 0.00014f, 7, true },
                    { 173, "Mix", 24, 0.00014f, 12, true },
                    { 174, "Mix", 24, 0.00014f, 9, true },
                    { 175, "Mix", 24, 0.00069f, 15, true },
                    { 176, "Mix", 24, 0.0007f, 16, true },
                    { 177, "Mix", 25, 0.165f, 1, true },
                    { 178, "Mix", 25, 0.016f, 23, true },
                    { 179, "Mix", 25, 0.0024f, 3, true },
                    { 180, "Mix", 25, 0.04f, 2, true },
                    { 181, "Mix", 25, 0.0008f, 5, true },
                    { 182, "Mix", 25, 0.0016f, 4, true },
                    { 183, "Mix", 25, 0.0008f, 7, true },
                    { 184, "Mix", 25, 0.0008f, 12, true },
                    { 185, "Mix", 25, 0.0008f, 9, true },
                    { 186, "Mix", 25, 0.004f, 15, true },
                    { 187, "Mix", 25, 0.0034f, 16, true },
                    { 188, "Masala", 25, 0.02f, 68, true },
                    { 189, "Masala", 25, 0.0133f, 9, true },
                    { 190, "Masala", 25, 0.0133f, 7, true },
                    { 191, "Masala", 25, 0.0013f, 19, true },
                    { 192, "Masala", 25, 0.0267f, 51, true },
                    { 193, "Masala", 25, 0.0333f, 11, true },
                    { 194, "Masala", 25, 0.107f, 2, true },
                    { 195, "Masala", 25, 0.011f, 10, true },
                    { 196, "Masala", 25, 0.02f, 52, true },
                    { 197, "Masala", 25, 0.0233f, 53, true },
                    { 198, "Masala", 25, 0.067f, 21, true },
                    { 199, "Mix", 26, 0.035f, 1, true },
                    { 200, "Mix", 26, 0.0035f, 23, true },
                    { 201, "Mix", 26, 0.00053f, 3, true },
                    { 202, "Mix", 26, 0.0088f, 2, true },
                    { 203, "Mix", 26, 0.00018f, 5, true },
                    { 204, "Mix", 26, 0.0036f, 4, true },
                    { 205, "Mix", 26, 0.00018f, 7, true },
                    { 206, "Mix", 26, 0.00018f, 12, true },
                    { 207, "Mix", 26, 0.00018f, 9, true },
                    { 208, "Mix", 26, 0.00088f, 15, true },
                    { 209, "Mix", 26, 0.0009f, 16, true },
                    { 210, "Mix", 72, 0.115f, 1, true },
                    { 211, "Mix", 72, 0.0115f, 23, true },
                    { 212, "Mix", 72, 0.0023f, 3, true },
                    { 213, "Mix", 72, 0.0115f, 2, true },
                    { 214, "Mix", 72, 0.0115f, 7, true },
                    { 215, "Mix", 72, 0.0115f, 9, true },
                    { 216, "Mix", 72, 0.0058f, 15, true },
                    { 217, "Mix", 72, 0.006f, 8, true },
                    { 218, "Mix", 72, 0.014f, 51, true },
                    { 219, "Mix", 72, 0.008f, 19, true },
                    { 220, "Mix", 28, 0.12f, 1, true },
                    { 221, "Mix", 28, 0.012f, 23, true },
                    { 222, "Mix", 28, 0.0018f, 3, true },
                    { 223, "Mix", 28, 0.036f, 2, true },
                    { 224, "Mix", 28, 0.012f, 7, true },
                    { 225, "Mix", 28, 0.012f, 9, true },
                    { 226, "Mix", 28, 0.006f, 15, true },
                    { 227, "Mix", 28, 0.01f, 12, true },
                    { 228, "Mix", 28, 0.0024f, 19, true },
                    { 229, "Mix", 29, 0.035f, 1, true },
                    { 230, "Mix", 29, 0.0035f, 23, true },
                    { 231, "Mix", 29, 0.0005f, 3, true },
                    { 232, "Mix", 29, 0.0105f, 2, true },
                    { 233, "Mix", 29, 0.0035f, 7, true },
                    { 234, "Mix", 29, 0.0035f, 9, true },
                    { 235, "Mix", 29, 0.0018f, 15, true },
                    { 236, "Mix", 29, 0.0007f, 19, true },
                    { 237, "Mix", 30, 0.385f, 1, true },
                    { 238, "Mix", 30, 0.508f, 2, true },
                    { 239, "Mix", 30, 0.319f, 26, true },
                    { 240, "Mix", 30, 0.0654f, 12, true },
                    { 241, "Mix", 30, 0.308f, 7, true },
                    { 242, "Mix", 30, 0.308f, 9, true },
                    { 243, "Mix", 30, 0.0031f, 5, true },
                    { 244, "Mix", 30, 0.0031f, 4, true },
                    { 245, "Mix", 30, 11.54f, 6, true },
                    { 246, "Mix", 30, 0.0031f, 40, true },
                    { 247, "Mix", 30, 0.0038f, 14, true },
                    { 248, "Mix", 30, 0.0031f, 5, true },
                    { 249, "Mix", 30, 0.02f, 39, true },
                    { 250, "Mix", 31, 0.385f, 1, true },
                    { 251, "Mix", 31, 0.508f, 2, true },
                    { 252, "Mix", 31, 0.319f, 26, true },
                    { 253, "Mix", 31, 0.0654f, 12, true },
                    { 254, "Mix", 31, 0.308f, 7, true },
                    { 255, "Mix", 31, 0.308f, 9, true },
                    { 256, "Mix", 31, 0.0031f, 5, true },
                    { 257, "Mix", 31, 0.0031f, 4, true },
                    { 258, "Mix", 31, 11.54f, 6, true },
                    { 259, "Mix", 31, 0.0031f, 40, true },
                    { 260, "Mix", 31, 0.0038f, 14, true },
                    { 261, "Mix", 31, 0.0031f, 5, true },
                    { 262, "Mix", 33, 0.385f, 1, true },
                    { 263, "Mix", 33, 0.508f, 2, true },
                    { 264, "Mix", 33, 0.319f, 26, true },
                    { 265, "Mix", 33, 0.0654f, 12, true },
                    { 266, "Mix", 33, 0.308f, 7, true },
                    { 267, "Mix", 33, 0.308f, 9, true },
                    { 268, "Mix", 33, 0.0031f, 5, true },
                    { 269, "Mix", 33, 0.0031f, 4, true },
                    { 270, "Mix", 33, 11.54f, 6, true },
                    { 271, "Mix", 33, 0.0031f, 40, true },
                    { 272, "Mix", 33, 0.0038f, 14, true },
                    { 273, "Mix", 33, 0.0031f, 5, true },
                    { 274, "Mix", 33, 0.3f, 52, true },
                    { 275, "Mix", 32, 0.385f, 1, true },
                    { 276, "Mix", 32, 0.508f, 2, true },
                    { 277, "Mix", 32, 0.319f, 26, true },
                    { 278, "Mix", 32, 0.0654f, 12, true },
                    { 279, "Mix", 32, 0.308f, 7, true },
                    { 280, "Mix", 32, 0.308f, 9, true },
                    { 281, "Mix", 32, 0.0031f, 5, true },
                    { 282, "Mix", 32, 0.0031f, 4, true },
                    { 283, "Mix", 32, 11.54f, 6, true },
                    { 284, "Mix", 32, 0.0031f, 40, true },
                    { 285, "Mix", 32, 0.0038f, 14, true },
                    { 286, "Mix", 32, 0.0031f, 5, true },
                    { 287, "Mix", 32, 0.3f, 81, true },
                    { 288, "Mix", 73, 0.385f, 1, true },
                    { 289, "Mix", 73, 0.508f, 2, true },
                    { 290, "Mix", 73, 0.319f, 26, true },
                    { 291, "Mix", 73, 0.0654f, 12, true },
                    { 292, "Mix", 73, 0.308f, 7, true },
                    { 293, "Mix", 73, 0.308f, 9, true },
                    { 294, "Mix", 73, 0.0031f, 5, true },
                    { 295, "Mix", 73, 0.0031f, 4, true },
                    { 296, "Mix", 73, 11.54f, 6, true },
                    { 297, "Mix", 73, 0.0031f, 40, true },
                    { 298, "Mix", 73, 0.0038f, 14, true },
                    { 299, "Mix", 73, 0.0031f, 5, true },
                    { 300, "Mix", 73, 0.3f, 54, true },
                    { 301, "Mix", 74, 0.125f, 1, true },
                    { 302, "Mix", 74, 0.162f, 2, true },
                    { 303, "Mix", 74, 0.119f, 26, true },
                    { 304, "Mix", 74, 0.0098f, 7, true },
                    { 305, "Mix", 74, 0.0098f, 9, true },
                    { 306, "Mix", 74, 0.0049f, 39, true },
                    { 307, "Mix", 74, 0.0049f, 8, true },
                    { 308, "Mix", 74, 0.001f, 29, true },
                    { 309, "Mix", 74, 0.001f, 30, true },
                    { 310, "Mix", 74, 0.001f, 5, true },
                    { 311, "Mix", 74, 0.001f, 32, true },
                    { 312, "Mix", 74, 0.0098f, 35, true },
                    { 313, "Mix", 74, 0.004f, 37, true },
                    { 314, "Mix", 74, 3.659f, 6, true },
                    { 315, "Mix", 74, 0.244f, 81, true },
                    { 316, "Mix", 74, 0.0049f, 38, true },
                    { 317, "Mix", 74, 0.001f, 40, true },
                    { 318, "Mix", 74, 0.002f, 14, true },
                    { 319, "Mix", 74, 0.00098f, 4, true },
                    { 320, "Mix", 74, 0.00098f, 31, true },
                    { 321, "Mix", 75, 0.0926f, 1, true },
                    { 322, "Mix", 75, 0.123f, 2, true },
                    { 323, "Mix", 75, 0.0926f, 31, true },
                    { 324, "Mix", 75, 0.007f, 7, true },
                    { 325, "Mix", 75, 0.007f, 9, true },
                    { 326, "Mix", 75, 0.004f, 39, true },
                    { 327, "Mix", 75, 0.004f, 8, true },
                    { 328, "Mix", 75, 0.0007f, 29, true },
                    { 329, "Mix", 75, 0.0007f, 30, true },
                    { 330, "Mix", 75, 0.0007f, 5, true },
                    { 331, "Mix", 75, 0.0007f, 32, true },
                    { 332, "Mix", 75, 0.007f, 35, true },
                    { 333, "Mix", 75, 0.003f, 37, true },
                    { 334, "Mix", 75, 2.78f, 6, true },
                    { 335, "Mix", 75, 0.185f, 81, true },
                    { 336, "Mix", 75, 0.004f, 38, true },
                    { 337, "Mix", 75, 0.0007f, 40, true },
                    { 338, "Mix", 75, 0.0012f, 14, true },
                    { 339, "Mix", 75, 0.0007f, 4, true },
                    { 340, "Mix", 75, 0.0007f, 31, true },
                    { 341, "Mix", 76, 0.0463f, 1, true },
                    { 342, "Mix", 76, 0.0615f, 2, true },
                    { 343, "Mix", 76, 0.0463f, 26, true },
                    { 344, "Mix", 76, 0.0035f, 7, true },
                    { 345, "Mix", 76, 0.0035f, 9, true },
                    { 346, "Mix", 76, 0.002f, 39, true },
                    { 347, "Mix", 76, 0.002f, 8, true },
                    { 348, "Mix", 76, 0.00035f, 29, true },
                    { 349, "Mix", 76, 0.00035f, 30, true },
                    { 350, "Mix", 76, 0.00035f, 5, true },
                    { 351, "Mix", 76, 0.00035f, 32, true },
                    { 352, "Mix", 76, 0.0035f, 35, true },
                    { 353, "Mix", 76, 0.0015f, 37, true },
                    { 354, "Mix", 76, 1.39f, 6, true },
                    { 355, "Mix", 76, 0.0925f, 81, true },
                    { 356, "Mix", 76, 0.002f, 38, true },
                    { 357, "Mix", 76, 0.00035f, 40, true },
                    { 358, "Mix", 76, 0.0006f, 14, true },
                    { 359, "Mix", 76, 0.00035f, 4, true },
                    { 360, "Mix", 76, 0.00035f, 31, true },
                    { 361, "Mix", 77, 0.313f, 1, true },
                    { 362, "Mix", 77, 0.416f, 2, true },
                    { 363, "Mix", 77, 0.313f, 26, true },
                    { 364, "Mix", 77, 0.025f, 7, true },
                    { 365, "Mix", 77, 0.025f, 9, true },
                    { 366, "Mix", 77, 0.0125f, 39, true },
                    { 367, "Mix", 77, 0.0125f, 8, true },
                    { 368, "Mix", 77, 0.0025f, 29, true },
                    { 369, "Mix", 77, 0.0025f, 30, true },
                    { 370, "Mix", 77, 0.0025f, 5, true },
                    { 371, "Mix", 77, 0.0025f, 32, true },
                    { 372, "Mix", 77, 0.025f, 35, true },
                    { 373, "Mix", 77, 0.0106f, 37, true },
                    { 374, "Mix", 77, 9.375f, 6, true },
                    { 375, "Mix", 77, 0.625f, 81, true },
                    { 376, "Mix", 77, 0.0125f, 38, true },
                    { 377, "Mix", 77, 0.0025f, 40, true },
                    { 378, "Mix", 77, 0.004f, 14, true },
                    { 379, "Mix", 77, 0.0025f, 4, true },
                    { 380, "Mix", 77, 0.0025f, 31, true },
                    { 381, "Mix", 78, 0.004f, 1, true },
                    { 382, "Mix", 78, 0.005f, 2, true },
                    { 383, "Mix", 78, 0.004f, 26, true },
                    { 384, "Mix", 78, 0.0003f, 7, true },
                    { 385, "Mix", 78, 0.0003f, 9, true },
                    { 386, "Mix", 78, 0.00011f, 39, true },
                    { 387, "Mix", 78, 0.00011f, 8, true },
                    { 388, "Mix", 78, 3E-05f, 29, true },
                    { 389, "Mix", 78, 3E-05f, 30, true },
                    { 390, "Mix", 78, 3E-05f, 5, true },
                    { 391, "Mix", 78, 3E-05f, 32, true },
                    { 392, "Mix", 78, 0.0003f, 35, true },
                    { 393, "Mix", 78, 0.0001f, 37, true },
                    { 394, "Mix", 78, 0.112f, 6, true },
                    { 395, "Mix", 78, 0.007f, 81, true },
                    { 396, "Mix", 78, 0.0001f, 38, true },
                    { 397, "Mix", 78, 3E-05f, 40, true },
                    { 398, "Mix", 78, 5E-05f, 14, true },
                    { 399, "Mix", 78, 3E-05f, 4, true },
                    { 400, "Mix", 78, 3E-05f, 31, true },
                    { 401, "Mix", 79, 0.343f, 75, true },
                    { 402, "Mix", 79, 0.343f, 1, true },
                    { 403, "Mix", 79, 0.343f, 2, true },
                    { 404, "Mix", 79, 0.258f, 16, true },
                    { 405, "Mix", 79, 0.043f, 7, true },
                    { 406, "Mix", 79, 0.043f, 9, true },
                    { 407, "Mix", 79, 9.14f, 6, true },
                    { 408, "Mix", 79, 0.343f, 45, true },
                    { 409, "Mix", 79, 0.0086f, 19, true },
                    { 410, "Mix", 79, 0.043f, 76, true },
                    { 411, "Mix", 79, 0.0086f, 38, true },
                    { 412, "Mix", 79, 0.043f, 36, true },
                    { 413, "Mix", 79, 0.017f, 33, true },
                    { 414, "Mix", 79, 0.043f, 10, true },
                    { 415, "Mix", 80, 0.1715f, 75, true },
                    { 416, "Mix", 80, 0.1715f, 1, true },
                    { 417, "Mix", 80, 0.1715f, 2, true },
                    { 418, "Mix", 80, 0.129f, 16, true },
                    { 419, "Mix", 80, 0.0215f, 7, true },
                    { 420, "Mix", 80, 0.0215f, 9, true },
                    { 421, "Mix", 80, 4.57f, 6, true },
                    { 422, "Mix", 80, 0.1715f, 45, true },
                    { 423, "Mix", 80, 0.0043f, 19, true },
                    { 424, "Mix", 80, 0.0215f, 76, true },
                    { 425, "Mix", 80, 0.0043f, 38, true },
                    { 426, "Mix", 80, 0.0215f, 36, true },
                    { 427, "Mix", 80, 0.0085f, 33, true },
                    { 428, "Mix", 80, 0.0215f, 10, true },
                    { 429, "Mix", 81, 0.08575f, 75, true },
                    { 430, "Mix", 81, 0.08575f, 1, true },
                    { 431, "Mix", 81, 0.08575f, 2, true },
                    { 432, "Mix", 81, 0.0645f, 16, true },
                    { 433, "Mix", 81, 0.01075f, 7, true },
                    { 434, "Mix", 81, 0.01075f, 9, true },
                    { 435, "Mix", 81, 2.285f, 6, true },
                    { 436, "Mix", 81, 0.08575f, 45, true },
                    { 437, "Mix", 81, 0.00215f, 19, true },
                    { 438, "Mix", 81, 0.01075f, 76, true },
                    { 439, "Mix", 81, 0.00215f, 38, true },
                    { 440, "Mix", 81, 0.01075f, 36, true },
                    { 441, "Mix", 81, 0.00425f, 33, true },
                    { 442, "Mix", 81, 0.01075f, 10, true },
                    { 443, "Mix", 82, 0.425f, 1, true },
                    { 444, "Mix", 82, 0.551f, 2, true },
                    { 445, "Mix", 82, 0.425f, 7, true },
                    { 446, "Mix", 82, 0.22f, 9, true },
                    { 447, "Mix", 82, 14.173f, 6, true },
                    { 448, "Mix", 82, 0.025f, 34, true },
                    { 449, "Mix", 83, 0.2125f, 1, true },
                    { 450, "Mix", 83, 0.2755f, 2, true },
                    { 451, "Mix", 83, 0.2125f, 7, true },
                    { 452, "Mix", 83, 0.11f, 9, true },
                    { 453, "Mix", 83, 7.0865f, 6, true },
                    { 454, "Mix", 83, 0.0125f, 34, true },
                    { 455, "Mix", 84, 0.10625f, 1, true },
                    { 456, "Mix", 84, 0.13775f, 2, true },
                    { 457, "Mix", 84, 0.10625f, 7, true },
                    { 458, "Mix", 84, 0.055f, 9, true },
                    { 459, "Mix", 84, 3.54325f, 6, true },
                    { 460, "Mix", 84, 0.00625f, 34, true },
                    { 461, "Mix", 85, 0.074375f, 1, true },
                    { 462, "Mix", 85, 0.096425f, 2, true },
                    { 463, "Mix", 85, 0.074375f, 7, true },
                    { 464, "Mix", 85, 0.0385f, 9, true },
                    { 465, "Mix", 85, 2.480275f, 6, true },
                    { 466, "Mix", 85, 0.004375f, 34, true },
                    { 467, "Mix", 43, 0.275f, 1, true },
                    { 468, "Mix", 43, 0.0275f, 23, true },
                    { 469, "Mix", 43, 0.004125f, 3, true },
                    { 470, "Mix", 43, 0.0275f, 2, true },
                    { 471, "Mix", 43, 0.001375f, 5, true },
                    { 472, "Mix", 43, 0.00275f, 4, true },
                    { 473, "Mix", 43, 0.0055f, 15, true },
                    { 474, "Mix", 43, 0.00275f, 16, true },
                    { 475, "Mix", 43, 0.275f, 6, true },
                    { 476, "Mix", 44, 0.157f, 1, true },
                    { 477, "Mix", 44, 0.07150003f, 20, true },
                    { 478, "Mix", 44, 0.015714293f, 23, true },
                    { 479, "Mix", 44, 0.002357144f, 3, true },
                    { 480, "Mix", 44, 0.015714293f, 2, true },
                    { 481, "Mix", 44, 0.0007857146f, 5, true },
                    { 482, "Mix", 44, 0.0015714292f, 4, true },
                    { 483, "Mix", 44, 0.0031428584f, 15, true },
                    { 484, "Mix", 44, 0.0015714292f, 16, true },
                    { 485, "Mix", 44, 0.15714292f, 6, true },
                    { 486, "Mix", 45, 0.02f, 1, true },
                    { 487, "Mix", 45, 0.002f, 23, true },
                    { 488, "Mix", 45, 0.0003f, 3, true },
                    { 489, "Mix", 45, 0.002f, 2, true },
                    { 490, "Mix", 45, 0.0001f, 5, true },
                    { 491, "Mix", 45, 0.0002f, 4, true },
                    { 492, "Mix", 45, 0.0004f, 15, true },
                    { 493, "Mix", 45, 0.0002f, 16, true },
                    { 494, "Mix", 45, 0.02f, 6, true },
                    { 495, "Mix", 46, 0.025f, 1, true },
                    { 496, "Mix", 46, 0.0025f, 23, true },
                    { 497, "Mix", 46, 0.000375f, 3, true },
                    { 498, "Mix", 46, 0.0025f, 2, true },
                    { 499, "Mix", 46, 0.000125f, 5, true },
                    { 500, "Mix", 46, 0.00025f, 4, true },
                    { 501, "Mix", 46, 0.0005f, 15, true },
                    { 502, "Mix", 46, 0.00025f, 16, true },
                    { 503, "Mix", 46, 0.025f, 6, true },
                    { 504, "Mix", 47, 0.035f, 1, true },
                    { 505, "Mix", 47, 0.0035f, 23, true },
                    { 506, "Mix", 47, 0.000525f, 3, true },
                    { 507, "Mix", 47, 0.0035f, 2, true },
                    { 508, "Mix", 47, 0.000175f, 5, true },
                    { 509, "Mix", 47, 0.00035f, 4, true },
                    { 510, "Mix", 47, 0.0007f, 15, true },
                    { 511, "Mix", 47, 0.00035f, 16, true },
                    { 512, "Mix", 47, 0.035f, 6, true },
                    { 513, "Mix", 48, 0.035f, 1, true },
                    { 514, "Mix", 48, 0.0035f, 23, true },
                    { 515, "Mix", 48, 0.000525f, 3, true },
                    { 516, "Mix", 48, 0.00525f, 2, true },
                    { 517, "Mix", 48, 0.000175f, 5, true },
                    { 518, "Mix", 48, 0.00035f, 4, true },
                    { 519, "Mix", 48, 0.0007f, 15, true },
                    { 520, "Mix", 48, 0.00035f, 16, true },
                    { 521, "Mix", 48, 0.035f, 6, true },
                    { 522, "Mix", 49, 0.04f, 1, true },
                    { 523, "Mix", 49, 0.0036f, 23, true },
                    { 524, "Mix", 49, 0.0006f, 3, true },
                    { 525, "Mix", 49, 0.006f, 2, true },
                    { 526, "Mix", 49, 0.0002f, 5, true },
                    { 527, "Mix", 49, 0.0004f, 4, true },
                    { 528, "Mix", 49, 0.0008f, 15, true },
                    { 529, "Mix", 49, 0.0004f, 16, true },
                    { 530, "Mix", 49, 0.04f, 6, true },
                    { 531, "Mix", 50, 0.04f, 1, true },
                    { 532, "Mix", 50, 0.0036f, 23, true },
                    { 533, "Mix", 50, 0.0006f, 3, true },
                    { 534, "Mix", 50, 0.006f, 2, true },
                    { 535, "Mix", 50, 0.0002f, 5, true },
                    { 536, "Mix", 50, 0.0004f, 4, true },
                    { 537, "Mix", 50, 0.0008f, 15, true },
                    { 538, "Mix", 50, 0.0004f, 16, true },
                    { 539, "Mix", 50, 0.04f, 6, true },
                    { 540, "Mix", 51, 0.04f, 1, true },
                    { 541, "Mix", 51, 0.0036f, 23, true },
                    { 542, "Mix", 51, 0.0006f, 3, true },
                    { 543, "Mix", 51, 0.006f, 2, true },
                    { 544, "Mix", 51, 0.0002f, 5, true },
                    { 545, "Mix", 51, 0.0004f, 4, true },
                    { 546, "Mix", 51, 0.0008f, 15, true },
                    { 547, "Mix", 51, 0.0004f, 16, true },
                    { 548, "Mix", 51, 0.04f, 6, true },
                    { 549, "Mix", 52, 0.04f, 1, true },
                    { 550, "Mix", 52, 0.0036f, 23, true },
                    { 551, "Mix", 52, 0.0006f, 3, true },
                    { 552, "Mix", 52, 0.006f, 2, true },
                    { 553, "Mix", 52, 0.0002f, 5, true },
                    { 554, "Mix", 52, 0.0004f, 4, true },
                    { 555, "Mix", 52, 0.0008f, 15, true },
                    { 556, "Mix", 52, 0.0004f, 16, true },
                    { 557, "Mix", 52, 0.04f, 6, true },
                    { 558, "Mix", 53, 0.04f, 1, true },
                    { 559, "Mix", 53, 0.0036f, 23, true },
                    { 560, "Mix", 53, 0.0006f, 3, true },
                    { 561, "Mix", 53, 0.006f, 2, true },
                    { 562, "Mix", 53, 0.0002f, 5, true },
                    { 563, "Mix", 53, 0.0004f, 4, true },
                    { 564, "Mix", 53, 0.0008f, 15, true },
                    { 565, "Mix", 53, 0.0004f, 16, true },
                    { 566, "Mix", 53, 0.04f, 6, true },
                    { 567, "Mix", 54, 0.035f, 1, true },
                    { 568, "Mix", 54, 0.0035f, 23, true },
                    { 569, "Mix", 54, 0.000525f, 3, true },
                    { 570, "Mix", 54, 0.0035f, 2, true },
                    { 571, "Mix", 54, 0.000175f, 5, true },
                    { 572, "Mix", 54, 0.00035f, 4, true },
                    { 573, "Mix", 54, 0.0007f, 15, true },
                    { 574, "Mix", 54, 0.00035f, 16, true },
                    { 575, "Mix", 54, 0.035f, 6, true },
                    { 576, "Mix", 55, 0.05f, 1, true },
                    { 577, "Mix", 55, 0.0045f, 23, true },
                    { 578, "Mix", 55, 0.00075f, 3, true },
                    { 579, "Mix", 55, 0.0075f, 2, true },
                    { 580, "Mix", 55, 0.00025f, 5, true },
                    { 581, "Mix", 55, 0.0005f, 4, true },
                    { 582, "Mix", 55, 0.001f, 15, true },
                    { 583, "Mix", 55, 0.0005f, 16, true },
                    { 584, "Mix", 55, 0.05f, 6, true },
                    { 585, "Mix", 56, 0.05f, 1, true },
                    { 586, "Mix", 56, 0.0045f, 23, true },
                    { 587, "Mix", 56, 0.00075f, 3, true },
                    { 588, "Mix", 56, 0.0075f, 2, true },
                    { 589, "Mix", 56, 0.00025f, 5, true },
                    { 590, "Mix", 56, 0.0005f, 4, true },
                    { 591, "Mix", 56, 0.001f, 15, true },
                    { 592, "Mix", 56, 0.0005f, 16, true },
                    { 593, "Mix", 56, 0.05f, 6, true },
                    { 594, "Mix", 57, 0.05f, 1, true },
                    { 595, "Mix", 57, 0.0045f, 23, true },
                    { 596, "Mix", 57, 0.00075f, 3, true },
                    { 597, "Mix", 57, 0.0075f, 2, true },
                    { 598, "Mix", 57, 0.00025f, 5, true },
                    { 599, "Mix", 57, 0.0005f, 4, true },
                    { 600, "Mix", 57, 0.001f, 15, true },
                    { 601, "Mix", 57, 0.0005f, 16, true },
                    { 602, "Mix", 57, 0.05f, 6, true },
                    { 603, "Mix", 86, 7f, 1, true },
                    { 604, "Mix", 86, 6.0004f, 2, true },
                    { 605, "Mix", 86, 4.501f, 26, true },
                    { 606, "Mix", 86, 0.5005f, 89, true },
                    { 607, "Mix", 86, 0.203f, 7, true },
                    { 608, "Mix", 86, 0.0399f, 19, true },
                    { 609, "Mix", 86, 0.0399f, 5, true },
                    { 610, "Mix", 86, 0.0399f, 4, true },
                    { 611, "Mix", 86, 0.0399f, 32, true },
                    { 612, "Mix", 86, 120.001f, 6, true },
                    { 613, "Mix", 86, 0.0399f, 14, true },
                    { 614, "Mix", 86, 0.0245f, 58, true },
                    { 615, "Mix", 86, 0.0098f, 48, true },
                    { 616, "Mix", 86, 0.0098f, 60, true },
                    { 617, "Mix", 86, 0.0098f, 12, true },
                    { 618, "Mix", 86, 0.203f, 9, true },
                    { 619, "Mix", 87, 0.088f, 1, true },
                    { 620, "Mix", 87, 0.0754336f, 2, true },
                    { 621, "Mix", 87, 0.056584f, 26, true },
                    { 622, "Mix", 87, 0.006292f, 89, true },
                    { 623, "Mix", 87, 0.002552f, 7, true },
                    { 624, "Mix", 87, 0.0005016f, 19, true },
                    { 625, "Mix", 87, 0.0005016f, 5, true },
                    { 626, "Mix", 87, 0.0005016f, 4, true },
                    { 627, "Mix", 87, 0.0005016f, 32, true },
                    { 628, "Mix", 87, 1.508584f, 6, true },
                    { 629, "Mix", 87, 0.0005016f, 14, true },
                    { 630, "Mix", 87, 0.000308f, 58, true },
                    { 631, "Mix", 87, 0.0001232f, 48, true },
                    { 632, "Mix", 87, 0.0001232f, 60, true },
                    { 633, "Mix", 87, 0.0001232f, 12, true },
                    { 634, "Mix", 87, 0.002552f, 9, true },
                    { 635, "Mix", 88, 6f, 1, true },
                    { 636, "Mix", 88, 1.1997f, 2, true },
                    { 637, "Mix", 88, 0.6f, 23, true },
                    { 638, "Mix", 88, 0.12f, 15, true },
                    { 639, "Mix", 88, 0.0996f, 7, true },
                    { 640, "Mix", 88, 0.0996f, 9, true },
                    { 641, "Mix", 88, 0.0318f, 5, true },
                    { 642, "Mix", 88, 0.0318f, 4, true },
                    { 643, "Mix", 88, 0.5004f, 90, true },
                    { 644, "Mix", 88, 0.0318f, 32, true },
                    { 645, "Mix", 88, 0.3f, 53, true },
                    { 646, "Mix", 88, 0.0318f, 91, true },
                    { 647, "Mix", 88, 0.0198f, 29, true },
                    { 648, "Mix", 88, 0.0318f, 19, true },
                    { 649, "Mix", 89, 0.146f, 1, true },
                    { 650, "Mix", 89, 0.0291927f, 2, true },
                    { 651, "Mix", 89, 0.0146f, 23, true },
                    { 652, "Mix", 89, 0.00292f, 15, true },
                    { 653, "Mix", 89, 0.0024236f, 7, true },
                    { 654, "Mix", 89, 0.0024236f, 9, true },
                    { 655, "Mix", 89, 0.0007738f, 5, true },
                    { 656, "Mix", 89, 0.0007738f, 4, true },
                    { 657, "Mix", 89, 0.0121764f, 90, true },
                    { 658, "Mix", 89, 0.0007738f, 32, true },
                    { 659, "Mix", 89, 0.0073f, 53, true },
                    { 660, "Mix", 89, 0.0007738f, 91, true },
                    { 661, "Mix", 89, 0.0004818f, 29, true },
                    { 662, "Mix", 89, 0.0007738f, 19, true },
                    { 663, "Mix", 90, 0.036f, 70, true },
                    { 664, "Mix", 90, 0.607f, 6, true },
                    { 665, "Mix", 90, 0.036f, 16, true },
                    { 666, "Mix", 90, 0.014f, 60, true },
                    { 667, "Mix", 91, 0.036f, 70, true },
                    { 668, "Mix", 91, 0.607f, 6, true },
                    { 669, "Mix", 91, 0.036f, 16, true },
                    { 670, "Mix", 91, 0.014f, 52, true },
                    { 671, "Mix", 92, 0.036f, 70, true },
                    { 672, "Mix", 92, 0.607f, 6, true },
                    { 673, "Mix", 92, 0.036f, 16, true },
                    { 674, "Mix", 92, 0.002f, 92, true },
                    { 675, "Mix", 93, 0.036f, 70, true },
                    { 676, "Mix", 93, 0.607f, 6, true },
                    { 677, "Mix", 93, 0.036f, 16, true },
                    { 678, "Mix", 93, 0.014f, 51, true }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Marble Cake");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Tea Cake");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Butter Plum");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Strawberry Cake");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "PINEAPPALE CAKE");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "Kubboos");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 28,
                column: "Name",
                value: "WhiteChocolate");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 58,
                column: "Name",
                value: "Vanila");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialId",
                keyValue: 62,
                column: "Name",
                value: "Lemon");
        }
    }
}
