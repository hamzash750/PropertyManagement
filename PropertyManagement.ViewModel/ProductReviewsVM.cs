using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.ViewModel
{
    public class ProductReviewsVM
    {
        public int PropertyId { get; set; }
        public string User { get; set; }
        public string ReviewTittle { get; set; }
        
        public int Rate { get; set; }
        public string ReviewComents { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
