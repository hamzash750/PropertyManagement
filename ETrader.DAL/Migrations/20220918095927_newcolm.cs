using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETrader.DAL.Migrations
{
    public partial class newcolm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 18, 14, 59, 26, 152, DateTimeKind.Local).AddTicks(6397), new DateTime(2022, 9, 18, 14, 59, 26, 152, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 18, 14, 59, 26, 152, DateTimeKind.Local).AddTicks(9489), new DateTime(2022, 9, 18, 14, 59, 26, 152, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 18, 14, 59, 26, 152, DateTimeKind.Local).AddTicks(9502), new DateTime(2022, 9, 18, 14, 59, 26, 152, DateTimeKind.Local).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 18, 14, 59, 26, 154, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 9, 18, 14, 59, 26, 154, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "PropertyFinders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 18, 14, 59, 26, 154, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 9, 18, 14, 59, 26, 154, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 9, 18, 14, 59, 26, 155, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDase",
                value: new DateTime(2022, 9, 18, 14, 59, 26, 153, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDase",
                value: new DateTime(2022, 9, 18, 14, 59, 26, 153, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 18, 14, 59, 26, 146, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 9, 18, 14, 59, 26, 148, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 9, 18, 14, 59, 26, 148, DateTimeKind.Local).AddTicks(4306));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 15, 13, 10, 41, 637, DateTimeKind.Local).AddTicks(1329), new DateTime(2022, 9, 15, 13, 10, 41, 637, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 15, 13, 10, 41, 637, DateTimeKind.Local).AddTicks(3062), new DateTime(2022, 9, 15, 13, 10, 41, 637, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 9, 15, 13, 10, 41, 637, DateTimeKind.Local).AddTicks(3074), new DateTime(2022, 9, 15, 13, 10, 41, 637, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 13, 10, 41, 638, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 13, 10, 41, 638, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "PropertyFinders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 13, 10, 41, 638, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 9, 15, 13, 10, 41, 638, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 9, 15, 13, 10, 41, 638, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDase",
                value: new DateTime(2022, 9, 15, 13, 10, 41, 637, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDase",
                value: new DateTime(2022, 9, 15, 13, 10, 41, 637, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 13, 10, 41, 633, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 13, 10, 41, 635, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 9, 15, 13, 10, 41, 635, DateTimeKind.Local).AddTicks(201));
        }
    }
}
