﻿using ETrader.DAL.Model;
using ETrader.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.Business.Interface
{
    public interface IUserService
    {
        List<User> getAllAgent ();
        void sendAdminEmail(ContactUsVM obj);
    }
}
