using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.DAL.Model
{
    public class PropertyChat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
    }
}
