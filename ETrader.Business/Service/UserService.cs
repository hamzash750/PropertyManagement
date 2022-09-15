using ETrader.Business.Interface;
using ETrader.DAL;
using ETrader.DAL.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.Business.Service
{
    public class UserService : IUserService
    {
        private MyContext context = null;
        private IConfiguration configuration;
        public UserService(MyContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        public List<User> getAllAgent()
        {
            return context.Users.Where(x=>x.UType=="S").ToList();
        }
    }
}
