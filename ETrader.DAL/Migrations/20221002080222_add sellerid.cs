using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETrader.DAL.Migrations
{
    public partial class addsellerid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "PropertyReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "PropertyReviews");

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
    }
}
