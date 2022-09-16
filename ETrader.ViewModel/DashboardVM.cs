using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.ViewModel
{
    public class DashboardVM
    {
        public int SalePropertyCount { get; set; }
        public int PurchasePropertyCount { get; set; }
        public int TotalFinderRequset { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalReviews { get; set; }
        public int TotalChat { get; set; }
    }
}
