using Microsoft.EntityFrameworkCore;
using ETrader.DAL.Model;
using System;

namespace ETrader.DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
        {

        }
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<PropertyCategory> PropertyCategorys { get; set; }
        public virtual DbSet<PropertyAds> PropertyAds { get; set; }
        public virtual DbSet<PropertySale> PropertySales { get; set; }
        public virtual DbSet<PropertyFinder> PropertyFinders { get; set; }
        public virtual DbSet<PropertyChat> PropertyChats { get; set; }
        public virtual DbSet<PropertyReviews> PropertyReviews { get; set; }
        public virtual DbSet<SellerProof> SellerProofs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, Name = "Jhon", Email = "jhon@gmail.com", Password = "12345", Phone = "03006406512", Address = "This is test Address", UType = "B",DateTime=DateTime.Now},
                 new User() { Id = 2, Name = "Mark", Email = "Mark@gmail.com", Password = "43545", Phone = "03006406512", Address = "This is test Address", UType = "S", DateTime = DateTime.Now },
                  new User() { Id = 3, Name = "Smith", Email = "Smith@gmail.com", Password = "98765", Phone = "03006406512", Address = "This is test Address", UType = "V", DateTime = DateTime.Now });
            modelBuilder.Entity<Admin>().HasData(
               new Admin() { Id = 1, UserName = "Admin", Password = "admin" });
            modelBuilder.Entity<PropertyType>().HasData(
              new PropertyType() { Id = 1, Type="Buy/Sell"}, new PropertyType() { Id = 2, Type = "Rental"});
            modelBuilder.Entity<PropertyCategory>().HasData(
              new PropertyCategory() { Id = 1, Tittle = "Land & Plots" ,Description="test", PropertyTypeId =1},
               new PropertyCategory() { Id = 2, Tittle = "Houses", PropertyTypeId = 1 },
                 new PropertyCategory() { Id = 3, Tittle = "Apartments & Flats", PropertyTypeId = 1 },
                 new PropertyCategory() { Id =4, Tittle = "Shop - Offices - Commercial Space", PropertyTypeId = 2 },
                   new PropertyCategory() { Id = 5, Tittle = "Portions & Floors", PropertyTypeId = 2 },
                   new PropertyCategory() { Id = 6, Tittle = "Property for Rent", PropertyTypeId = 2 }
              );
            modelBuilder.Entity<PropertyAds>().HasData(
               new PropertyAds() { Id = 1,Tittle= "5 Marla Double Story House Is Available For Sale",Area=5,AreaUnit= "Marla",CategoryId=2,Quantity=20,Location= "SAN FRANCISCO, CA 55689",
                   Description = "Some of the prominent features of this property are as follows. ",Images= "house.jfif",ModifiedDate=DateTime.Now,PostDate=DateTime.Now,Price=1000000,SellerId=2},
                new PropertyAds()
                {
                    Id = 2,
                    Tittle = "60 Marla Double Story House Is Available For Sale",
                    Area = 6,
                    AreaUnit = "Marla",
                    CategoryId = 2,
                    Description = "Block Sector D Bahria TownSome of the prominent features of this property are as follows. ",
                    Images = "house.jfif",
                    ModifiedDate = DateTime.Now,
                    PostDate = DateTime.Now,
                    Price = 5000000,
                    Quantity=5,
                    SellerId = 2,
                    Location = "SAN FRANCISCO, CA 55689"
                },
                 new PropertyAds()
                 {
                     Id = 3,
                     Tittle = "7 Marla Double Story House Is Available For Sale",
                     Area = 7,
                     AreaUnit = "Marla",
                     CategoryId = 3,
                     Description = "BeautiFul Location Close To",
                     Images = "house.jfif",
                     ModifiedDate = DateTime.Now,
                     PostDate = DateTime.Now,
                     Price = 2000000,
                     Quantity = 10,
                     SellerId = 2,
                     Location = "SAN FRANCISCO, CA 55689",
                 }
               );
            modelBuilder.Entity<PropertySale>().HasData(
              new PropertySale()
              {
                  Id = 1,
                  BuyerId=1,
                  CategoryId=2,
                  PropertyId=1,
                  PurchaseDase=DateTime.Now,
                  PaidAmount=10000000,
                  Qty=1,
                  SellerId=2,
                  TransactionId="123123123"
              },
             new PropertySale()
             {
                 Id = 2,
                 BuyerId = 1,
                 CategoryId = 2,
                 PropertyId = 2,
                 PurchaseDase = DateTime.Now,
                 PaidAmount = 40000000,
                 Qty = 1,
                 SellerId = 2,
                 TransactionId = "34234234"
             }
              );
            modelBuilder.Entity<PropertyFinder>().HasData(
         new PropertyFinder()
         {
             Id = 1,
             Title="Need Room",
             Description="Need Room 5 * 5 Near Arfa Tower",
             PriceExpectations=4000,
             DateTime = DateTime.Now,
             UserId=3
         }
         );
            modelBuilder.Entity<PropertyChat>().HasData(
       new PropertyChat()
       {
           Id = 1,
          BuyerId=1,
          SellerId=2,
          DateTime=DateTime.Now,
          Message="Hello Any Room Available?"
       },
       new PropertyChat()
       {
                Id = 2,
          BuyerId = 1,
          SellerId = 2,
          DateTime = DateTime.Now,
          Message = "Yes Availale!"
       }
       );
            modelBuilder.Entity<PropertyReviews>().HasData(
      new PropertyReviews()
      {
          Id = 1,
         CreateAt=DateTime.Now,
         PropertyId=1,
         Rate=4,
          ReviewTittle="Product Re",
         ReviewComents ="Very Good Experience",
         UserId=2
      },
      new PropertyReviews()
      {
          Id = 2,
          CreateAt = DateTime.Now,
          PropertyId = 2,
          Rate = 5,
          ReviewTittle = "Product Quailty",
          ReviewComents = "Excellent!",
          UserId = 3
      }
      );

            modelBuilder.Entity<SellerProof>().HasData(
                 new SellerProof()
                 {
                     Id = 1,
                     SellerId=2,
                     Document="onwer.pdf",
                     DocumentType="Owner Ship"
                 },
                 new SellerProof()
                 {
                     Id = 2,
                     SellerId = 2,
                     Document = "Registery.jpg",
                     DocumentType = "Registery"
                 }
                 );

        }
    }
}
