using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETrader.DAL.Migrations
{
    public partial class dll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 10, 2, 15, 8, 5, 669, DateTimeKind.Local).AddTicks(3471), new DateTime(2022, 10, 2, 15, 8, 5, 669, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 10, 2, 15, 8, 5, 669, DateTimeKind.Local).AddTicks(5949), new DateTime(2022, 10, 2, 15, 8, 5, 669, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 10, 2, 15, 8, 5, 669, DateTimeKind.Local).AddTicks(5961), new DateTime(2022, 10, 2, 15, 8, 5, 669, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 15, 8, 5, 670, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 15, 8, 5, 671, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "PropertyFinders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 15, 8, 5, 670, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 10, 2, 15, 8, 5, 671, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 10, 2, 15, 8, 5, 671, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDase",
                value: new DateTime(2022, 10, 2, 15, 8, 5, 669, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDase",
                value: new DateTime(2022, 10, 2, 15, 8, 5, 670, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 15, 8, 5, 663, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 15, 8, 5, 665, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 15, 8, 5, 665, DateTimeKind.Local).AddTicks(9227));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 10, 2, 13, 4, 46, 10, DateTimeKind.Local).AddTicks(8021), new DateTime(2022, 10, 2, 13, 4, 46, 10, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 10, 2, 13, 4, 46, 10, DateTimeKind.Local).AddTicks(8981), new DateTime(2022, 10, 2, 13, 4, 46, 10, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 10, 2, 13, 4, 46, 10, DateTimeKind.Local).AddTicks(8989), new DateTime(2022, 10, 2, 13, 4, 46, 10, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 4, 46, 11, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 4, 46, 11, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "PropertyFinders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 4, 46, 11, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 10, 2, 13, 4, 46, 11, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 10, 2, 13, 4, 46, 11, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDase",
                value: new DateTime(2022, 10, 2, 13, 4, 46, 11, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDase",
                value: new DateTime(2022, 10, 2, 13, 4, 46, 11, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 4, 46, 7, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 4, 46, 9, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 4, 46, 9, DateTimeKind.Local).AddTicks(1341));
        }
    }
}
