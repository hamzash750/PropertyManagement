using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETrader.DAL.Migrations
{
    public partial class col : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 10, 2, 13, 2, 21, 134, DateTimeKind.Local).AddTicks(3132), new DateTime(2022, 10, 2, 13, 2, 21, 134, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 10, 2, 13, 2, 21, 134, DateTimeKind.Local).AddTicks(4769), new DateTime(2022, 10, 2, 13, 2, 21, 134, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 10, 2, 13, 2, 21, 134, DateTimeKind.Local).AddTicks(4782), new DateTime(2022, 10, 2, 13, 2, 21, 134, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 2, 21, 135, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 2, 21, 135, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "PropertyFinders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 2, 21, 135, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 10, 2, 13, 2, 21, 135, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 10, 2, 13, 2, 21, 135, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDase",
                value: new DateTime(2022, 10, 2, 13, 2, 21, 134, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDase",
                value: new DateTime(2022, 10, 2, 13, 2, 21, 134, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 2, 21, 129, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 2, 21, 131, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 10, 2, 13, 2, 21, 131, DateTimeKind.Local).AddTicks(4793));
        }
    }
}
