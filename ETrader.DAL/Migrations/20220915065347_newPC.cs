using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETrader.DAL.Migrations
{
    public partial class newPC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 15, 11, 53, 47, 268, DateTimeKind.Local).AddTicks(8252), new DateTime(2022, 9, 15, 11, 53, 47, 268, DateTimeKind.Local).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 15, 11, 53, 47, 268, DateTimeKind.Local).AddTicks(9242), new DateTime(2022, 9, 15, 11, 53, 47, 268, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 15, 11, 53, 47, 268, DateTimeKind.Local).AddTicks(9250), new DateTime(2022, 9, 15, 11, 53, 47, 268, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 11, 53, 47, 269, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 11, 53, 47, 269, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "PropertyFinders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 11, 53, 47, 269, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 9, 15, 11, 53, 47, 269, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 9, 15, 11, 53, 47, 269, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDase",
                value: new DateTime(2022, 9, 15, 11, 53, 47, 269, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDase",
                value: new DateTime(2022, 9, 15, 11, 53, 47, 269, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 11, 53, 47, 265, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 11, 53, 47, 266, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 11, 53, 47, 266, DateTimeKind.Local).AddTicks(4217));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 14, 11, 58, 42, 40, DateTimeKind.Local).AddTicks(42), new DateTime(2022, 9, 14, 11, 58, 42, 40, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 14, 11, 58, 42, 40, DateTimeKind.Local).AddTicks(1507), new DateTime(2022, 9, 14, 11, 58, 42, 40, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 14, 11, 58, 42, 40, DateTimeKind.Local).AddTicks(1517), new DateTime(2022, 9, 14, 11, 58, 42, 40, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 14, 11, 58, 42, 40, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 9, 14, 11, 58, 42, 41, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "PropertyFinders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 14, 11, 58, 42, 40, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 9, 14, 11, 58, 42, 41, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 9, 14, 11, 58, 42, 41, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDase",
                value: new DateTime(2022, 9, 14, 11, 58, 42, 40, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDase",
                value: new DateTime(2022, 9, 14, 11, 58, 42, 40, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 14, 11, 58, 42, 35, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 9, 14, 11, 58, 42, 37, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 9, 14, 11, 58, 42, 37, DateTimeKind.Local).AddTicks(4892));
        }
    }
}
