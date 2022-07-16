﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PropertyManagement.DAL;

namespace PropertyManagement.DAL.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220715193532_NewUdpate")]
    partial class NewUdpate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PropertyManagement.DAL.Model.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "admin",
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("PropertyManagement.DAL.Model.PropertyAds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("AreaUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertyAds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Area = 5m,
                            AreaUnit = "Marla",
                            CategoryId = 2,
                            Description = "Some of the prominent features of this property are as follows. ",
                            Images = "house.jfif",
                            ModifiedDate = new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(5259),
                            PostDate = new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(5830),
                            Price = 1000000m,
                            Quantity = 20,
                            SellerId = 2,
                            Tittle = "5 Marla Double Story House Is Available For Sale"
                        },
                        new
                        {
                            Id = 2,
                            Area = 6m,
                            AreaUnit = "Marla",
                            CategoryId = 2,
                            Description = "Block Sector D Bahria TownSome of the prominent features of this property are as follows. ",
                            Images = "house.jfif",
                            ModifiedDate = new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(7352),
                            PostDate = new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(7361),
                            Price = 5000000m,
                            Quantity = 5,
                            SellerId = 2,
                            Tittle = "6 Marla Double Story House Is Available For Sale"
                        },
                        new
                        {
                            Id = 3,
                            Area = 7m,
                            AreaUnit = "Marla",
                            CategoryId = 3,
                            Description = "BeautiFul Location Close To",
                            Images = "house.jfif",
                            ModifiedDate = new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(7368),
                            PostDate = new DateTime(2022, 7, 16, 0, 35, 31, 415, DateTimeKind.Local).AddTicks(7370),
                            Price = 2000000m,
                            Quantity = 10,
                            SellerId = 2,
                            Tittle = "7 Marla Double Story House Is Available For Sale"
                        });
                });

            modelBuilder.Entity("PropertyManagement.DAL.Model.PropertyCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertyCategorys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "test",
                            PropertyTypeId = 1,
                            Tittle = "Land & Plots"
                        },
                        new
                        {
                            Id = 2,
                            PropertyTypeId = 1,
                            Tittle = "Houses"
                        },
                        new
                        {
                            Id = 3,
                            PropertyTypeId = 1,
                            Tittle = "Apartments & Flats"
                        },
                        new
                        {
                            Id = 4,
                            PropertyTypeId = 2,
                            Tittle = "Shop - Offices - Commercial Space"
                        },
                        new
                        {
                            Id = 5,
                            PropertyTypeId = 2,
                            Tittle = "Portions & Floors"
                        });
                });

            modelBuilder.Entity("PropertyManagement.DAL.Model.PropertyChat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PropertyChats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuyerId = 1,
                            DateTime = new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(8212),
                            Message = "Hello Any Room Available?",
                            SellerId = 2
                        },
                        new
                        {
                            Id = 2,
                            BuyerId = 1,
                            DateTime = new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(8866),
                            Message = "Yes Availale!",
                            SellerId = 2
                        });
                });

            modelBuilder.Entity("PropertyManagement.DAL.Model.PropertyFinder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PriceExpectations")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PropertyFinders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTime = new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(5860),
                            Description = "Need Room 5 * 5 Near Arfa Tower",
                            PriceExpectations = 4000,
                            Title = "Need Room",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("PropertyManagement.DAL.Model.PropertyReviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("ReviewComents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PropertyReviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(9919),
                            PropertyId = 1,
                            Rate = 4,
                            ReviewComents = "Very Good Experience",
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2022, 7, 16, 0, 35, 31, 417, DateTimeKind.Local).AddTicks(1478),
                            PropertyId = 2,
                            Rate = 5,
                            ReviewComents = "Excellent!",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("PropertyManagement.DAL.Model.PropertySale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDase")
                        .HasColumnType("datetime2");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertySales");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuyerId = 1,
                            CategoryId = 2,
                            PaidAmount = 10000000m,
                            PropertyId = 1,
                            PurchaseDase = new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(333),
                            Qty = 1,
                            SellerId = 2,
                            TransactionId = "123123123"
                        },
                        new
                        {
                            Id = 2,
                            BuyerId = 1,
                            CategoryId = 2,
                            PaidAmount = 40000000m,
                            PropertyId = 2,
                            PurchaseDase = new DateTime(2022, 7, 16, 0, 35, 31, 416, DateTimeKind.Local).AddTicks(2884),
                            Qty = 1,
                            SellerId = 2,
                            TransactionId = "34234234"
                        });
                });

            modelBuilder.Entity("PropertyManagement.DAL.Model.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertyTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Buy/Sell"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Rental"
                        });
                });

            modelBuilder.Entity("PropertyManagement.DAL.Model.SellerProof", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SellerProofs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Document = "onwer.pdf",
                            DocumentType = "Owner Ship",
                            SellerId = 2
                        },
                        new
                        {
                            Id = 2,
                            Document = "Registery.jpg",
                            DocumentType = "Registery",
                            SellerId = 2
                        });
                });

            modelBuilder.Entity("PropertyManagement.DAL.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "This is test Address",
                            DateTime = new DateTime(2022, 7, 16, 0, 35, 31, 409, DateTimeKind.Local).AddTicks(5632),
                            Email = "jhon@gmail.com",
                            Name = "Jhon",
                            Password = "12345",
                            Phone = "03006406512",
                            UType = "B"
                        },
                        new
                        {
                            Id = 2,
                            Address = "This is test Address",
                            DateTime = new DateTime(2022, 7, 16, 0, 35, 31, 411, DateTimeKind.Local).AddTicks(9421),
                            Email = "Mark@gmail.com",
                            Name = "Mark",
                            Password = "43545",
                            Phone = "03006406512",
                            UType = "S"
                        },
                        new
                        {
                            Id = 3,
                            Address = "This is test Address",
                            DateTime = new DateTime(2022, 7, 16, 0, 35, 31, 411, DateTimeKind.Local).AddTicks(9466),
                            Email = "Smith@gmail.com",
                            Name = "Smith",
                            Password = "98765",
                            Phone = "03006406512",
                            UType = "V"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
