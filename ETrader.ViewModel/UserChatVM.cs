using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.ViewModel
{
    public class UserChatVM
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserChat { get; set; }
        public DateTime DateTime { get; set; }
    }
}
