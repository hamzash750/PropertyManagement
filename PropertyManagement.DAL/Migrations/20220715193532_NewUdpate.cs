using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManagement.DAL.Migrations
{
    public partial class NewUdpate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PropertyFinders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "DateTime", "UserId" },
                values: new object[] { new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(5860), 3 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PropertyFinders");

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 0, 28, 30, 901, DateTimeKind.Local).AddTicks(9596), new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(2344), new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "PropertyAds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "PostDate" },
                values: new object[] { new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(2362), new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 28, 30, 903, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "PropertyChats",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 28, 30, 903, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "PropertyFinders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 28, 30, 903, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 7, 16, 0, 28, 30, 903, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 7, 16, 0, 28, 30, 904, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDase",
                value: new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "PropertySales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDase",
                value: new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 28, 30, 894, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 28, 30, 896, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 7, 16, 0, 28, 30, 896, DateTimeKind.Local).AddTicks(7869));
        }
    }
}
