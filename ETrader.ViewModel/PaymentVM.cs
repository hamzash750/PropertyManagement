using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.ViewModel
{
    public class PaymentVM
    {
        public string Product { get; set; }
        public string Token { get; set; }
        public int PropertyId { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public int Amount { get; set; }
    }
}
