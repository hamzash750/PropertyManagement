using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.ViewModel
{
    public class SearchVM
    {
        public string Property { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public int Type { get; set; }
        public int Beds { get; set; }
        public int Bath { get; set; }
        public int PriceMin { get; set; }
        public int PriceMax { get; set; }
    }
}
