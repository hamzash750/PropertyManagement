using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManagement.DAL.Migrations
{
    public partial class n : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReviewTittle",
                table: "PropertyReviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 14, 35, 2, 661, DateTimeKind.Local).AddTicks(580), new DateTime(2022, 7, 16, 14, 35, 2, 661, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 14, 35, 2, 661, DateTimeKind.Local).AddTicks(2471), new DateTime(2022, 7, 16, 14, 35, 2, 661, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 14, 35, 2, 661, DateTimeKind.Local).AddTicks(2485), new DateTime(2022, 7, 16, 14, 35, 2, 661, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 14, 35, 2, 665, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 14, 35, 2, 665, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "PropertyFinders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 14, 35, 2, 664, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ReviewTittle" },
                values: new object[] { new DateTime(2022, 7, 16, 14, 35, 2, 665, DateTimeKind.Local).AddTicks(4268), "Product Re" });

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ReviewTittle" },
                values: new object[] { new DateTime(2022, 7, 16, 14, 35, 2, 665, DateTimeKind.Local).AddTicks(7036), "Product Quailty" });

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDase",
                value: new DateTime(2022, 7, 16, 14, 35, 2, 664, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDase",
                value: new DateTime(2022, 7, 16, 14, 35, 2, 664, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 14, 35, 2, 655, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 14, 35, 2, 657, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 14, 35, 2, 657, DateTimeKind.Local).AddTicks(1538));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewTittle",
                table: "PropertyReviews");

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(1069), new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(2661), new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(2676), new DateTime(2022, 7, 16, 13, 28, 16, 233, DateTimeKind.Local).AddTicks(2678) });

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
    }
}
