using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETrader.DAL.Migrations
{
    public partial class AddBathCOlumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Baths",
                table: "PropertyAds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bed",
                table: "PropertyAds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Garage",
                table: "PropertyAds",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Kitchen",
                table: "PropertyAds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OtherAmenites",
                table: "PropertyAds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Pool",
                table: "PropertyAds",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Baths",
                table: "PropertyAds");

            migrationBuilder.DropColumn(
                name: "Bed",
                table: "PropertyAds");

            migrationBuilder.DropColumn(
                name: "Garage",
                table: "PropertyAds");

            migrationBuilder.DropColumn(
                name: "Kitchen",
                table: "PropertyAds");

            migrationBuilder.DropColumn(
                name: "OtherAmenites",
                table: "PropertyAds");

            migrationBuilder.DropColumn(
                name: "Pool",
                table: "PropertyAds");

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
    }
}
