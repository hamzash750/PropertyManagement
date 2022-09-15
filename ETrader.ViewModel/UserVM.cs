﻿using System;

namespace ETrader.ViewModel
{
    public class UserVM
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string AccountType { get; set; }
        public string DateTime { get; set; }
    }
    public class LoginUserVM
    {
        public string Name { get; set; }
     
        public string AccessKey { get; set; }
        public string UserID { get; set; }
    }
}
