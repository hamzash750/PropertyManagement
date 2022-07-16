using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyManagement.DAL.Migrations
{
    public partial class DbTablewithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyAds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyChats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyChats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyFinders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceExpectations = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyFinders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    ReviewComents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyReviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertySales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDase = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertySales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SellerProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerProofs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "admin", "Admin" });

            migrationBuilder.InsertData(
                table: "PropertyAds",
                columns: new[] { "Id", "Area", "AreaUnit", "CategoryId", "Description", "Images", "ModifiedDate", "PostDate", "Price", "Quantity", "SellerId", "Tittle" },
                values: new object[,]
                {
                    { 1, 5m, "Marla", 2, "Some of the prominent features of this property are as follows. ", "house.jfif", new DateTime(2022, 7, 16, 0, 28, 30, 901, DateTimeKind.Local).AddTicks(9596), new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(337), 1000000m, 20, 2, "5 Marla Double Story House Is Available For Sale" },
                    { 2, 6m, "Marla", 2, "Block Sector D Bahria TownSome of the prominent features of this property are as follows. ", "house.jfif", new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(2344), new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(2355), 5000000m, 5, 2, "6 Marla Double Story House Is Available For Sale" },
                    { 3, 7m, "Marla", 3, "BeautiFul Location Close To", "house.jfif", new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(2362), new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(2365), 2000000m, 10, 2, "7 Marla Double Story House Is Available For Sale" }
                });

            migrationBuilder.InsertData(
                table: "PropertyCategorys",
                columns: new[] { "Id", "Description", "PropertyTypeId", "Tittle" },
                values: new object[,]
                {
                    { 1, "test", 1, "Land & Plots" },
                    { 2, null, 1, "Houses" },
                    { 3, null, 1, "Apartments & Flats" },
                    { 4, null, 2, "Shop - Offices - Commercial Space" },
                    { 5, null, 2, "Portions & Floors" }
                });

            migrationBuilder.InsertData(
                table: "PropertyChats",
                columns: new[] { "Id", "BuyerId", "DateTime", "Message", "SellerId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 7, 16, 0, 28, 30, 903, DateTimeKind.Local).AddTicks(5843), "Hello Any Room Available?", 2 },
                    { 2, 1, new DateTime(2022, 7, 16, 0, 28, 30, 903, DateTimeKind.Local).AddTicks(6968), "Yes Availale!", 2 }
                });

            migrationBuilder.InsertData(
                table: "PropertyFinders",
                columns: new[] { "Id", "DateTime", "Description", "PriceExpectations", "Title" },
                values: new object[] { 1, new DateTime(2022, 7, 16, 0, 28, 30, 903, DateTimeKind.Local).AddTicks(2682), "Need Room 5 * 5 Near Arfa Tower", 4000, "Need Room" });

            migrationBuilder.InsertData(
                table: "PropertyReviews",
                columns: new[] { "Id", "CreateAt", "PropertyId", "Rate", "ReviewComents", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 16, 0, 28, 30, 903, DateTimeKind.Local).AddTicks(9426), 1, 4, "Very Good Experience", 2 },
                    { 2, new DateTime(2022, 7, 16, 0, 28, 30, 904, DateTimeKind.Local).AddTicks(4889), 2, 5, "Excellent!", 3 }
                });

            migrationBuilder.InsertData(
                table: "PropertySales",
                columns: new[] { "Id", "BuyerId", "CategoryId", "PaidAmount", "PropertyId", "PurchaseDase", "Qty", "SellerId", "TransactionId" },
                values: new object[,]
                {
                    { 1, 1, 2, 10000000m, 1, new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(5908), 1, 2, "123123123" },
                    { 2, 1, 2, 40000000m, 2, new DateTime(2022, 7, 16, 0, 28, 30, 902, DateTimeKind.Local).AddTicks(9227), 1, 2, "34234234" }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Buy/Sell" },
                    { 2, "Rental" }
                });

            migrationBuilder.InsertData(
                table: "SellerProofs",
                columns: new[] { "Id", "Document", "DocumentType", "SellerId" },
                values: new object[,]
                {
                    { 1, "onwer.pdf", "Owner Ship", 2 },
                    { 2, "Registery.jpg", "Registery", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "DateTime", "Email", "Name", "Password", "Phone", "UType" },
                values: new object[,]
                {
                    { 1, "This is test Address", new DateTime(2022, 7, 16, 0, 28, 30, 894, DateTimeKind.Local).AddTicks(6102), "jhon@gmail.com", "Jhon", "12345", "03006406512", "B" },
                    { 2, "This is test Address", new DateTime(2022, 7, 16, 0, 28, 30, 896, DateTimeKind.Local).AddTicks(7832), "Mark@gmail.com", "Mark", "43545", "03006406512", "S" },
                    { 3, "This is test Address", new DateTime(2022, 7, 16, 0, 28, 30, 896, DateTimeKind.Local).AddTicks(7869), "Smith@gmail.com", "Smith", "98765", "03006406512", "V" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "PropertyAds");

            migrationBuilder.DropTable(
                name: "PropertyCategorys");

            migrationBuilder.DropTable(
                name: "PropertyChats");

            migrationBuilder.DropTable(
                name: "PropertyFinders");

            migrationBuilder.DropTable(
                name: "PropertyReviews");

            migrationBuilder.DropTable(
                name: "PropertySales");

            migrationBuilder.DropTable(
                name: "PropertyTypes");

            migrationBuilder.DropTable(
                name: "SellerProofs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
