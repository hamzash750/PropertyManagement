using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManagement.DAL.Migrations
{
    public partial class Newone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "PropertyAds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "ModifiedDate", "PostDate" },
                values: new object[] { "SAN FRANCISCO, CA 55689", new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(1069), new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "ModifiedDate", "PostDate" },
                values: new object[] { "SAN FRANCISCO, CA 55689", new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(2661), new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "ModifiedDate", "PostDate" },
                values: new object[] { "SAN FRANCISCO, CA 55689", new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(2676), new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 13, 28, 16, 234, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 13, 28, 16, 234, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "PropertyFinders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 7, 16, 13, 28, 16, 234, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 7, 16, 13, 28, 16, 234, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDase",
                value: new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDase",
                value: new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 13, 28, 16, 228, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 13, 28, 16, 229, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 13, 28, 16, 229, DateTimeKind.Local).AddTicks(5023));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "PropertyAds");

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(5259), new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(7352), new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(7368), new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "PropertyFinders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 7, 16, 0, 35, 31, 417, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDase",
                value: new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDase",
                value: new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 35, 31, 409, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 35, 31, 411, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 35, 31, 411, DateTimeKind.Local).AddTicks(9466));
        }
    }
}
