using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.DAL.Model
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
    }
}
