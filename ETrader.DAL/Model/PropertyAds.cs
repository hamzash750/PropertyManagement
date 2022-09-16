using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.DAL.Model
{
    public class PropertyAds
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Images { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string AreaUnit { get; set; }
        public decimal Area { get; set; }
        public decimal Price { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Quantity { get; set; }
        public int SellerId { get; set; }
        public int CategoryId { get; set; }
        public int Bed { get; set; }
        public int Baths { get; set; }
        public int Kitchen { get; set; }
        public bool Garage { get; set; }
        public bool Pool { get; set; }
        public string OtherAmenites { get; set; }
    }
    public class PropertyAdsVM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Images { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string AreaUnit { get; set; }
        public decimal Area { get; set; }
        public decimal Price { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Quantity { get; set; }
        public int SellerId { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public int Bed { get; set; }
        public int Baths { get; set; }
        public int Kitchen { get; set; }
        public bool Garage { get; set; }
        public bool Pool { get; set; }
        public string OtherAmenites { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
