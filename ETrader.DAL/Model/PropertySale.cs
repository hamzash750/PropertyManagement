using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.DAL.Model
{
    public class PropertySale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int CategoryId { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public int Qty { get; set; }
        public decimal PaidAmount { get; set; }
        public string TransactionId { get; set; }
        public DateTime PurchaseDase { get; set; }
    }
}
