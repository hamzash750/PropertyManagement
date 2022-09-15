using Microsoft.Extensions.Configuration;
using ETrader.Business.Interface;
using ETrader.DAL;
using ETrader.DAL.Model;
using ETrader.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrader.Business.Service
{
    public class AuthorizationService : IAuthorizationService
    {
        private MyContext context = null;
        private IConfiguration configuration;
        public AuthorizationService(MyContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        public bool Regsiter(RegisterVM obj)
        {
            try
            {
                var user = new User();
                user.Name = obj.Name;
                user.Email = obj.Email;
                user.Password = obj.Password;
                user.UType = obj.AccountType;
                user.Phone = obj.Phone;
                user.Address = obj.Address;
                var AddUser = context.Users.Add(user);
                var SaveUser = context.SaveChanges();
                if (SaveUser > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                return false;
            }
        }
        public LoginUserVM Login(RegisterVM obj)
        {
            try
            {
                var FindUser = context.Users.FirstOrDefault(x => x.Email == obj.Email && x.Password == obj.Password);
                if (FindUser != null)
                {
                    var user= new LoginUserVM();
                    user.UserID = FindUser.Id.ToString();
                    user.AccessKey = this.configuration.GetSection("APIAccessKey").Value.ToString();
                    user.Name = FindUser.Name;
                    return user;


                }
                else
                {
                    return new LoginUserVM() ;
                }
            }
            catch (Exception e)
            {
                return new LoginUserVM();

            }
        }
        public UserVM UserDetails(int UId)
        {
            try
            {
                var FindUser = context.Users.FirstOrDefault(x => x.Id==UId);
                if (FindUser != null)
                {
                    var Uvm = new UserVM();
                    Uvm.AccountType = FindUser.UType;
                    Uvm.Address = FindUser.Address;
                    Uvm.DateTime = FindUser.DateTime.ToShortDateString();
                    Uvm.Email = FindUser.Email;
                    Uvm.Name = FindUser.Name;
                    Uvm.Phone = FindUser.Phone;
                    return Uvm;
                }
                else
                {
                    return new UserVM();
                }
            }
            catch (Exception e)
            {
                return new UserVM();

            }
        }
        public bool checkAccessKey(string keyValue)
        {

            if (string.IsNullOrEmpty(keyValue))
                return false;

            var Accesskey = configuration.GetSection("APIAccessKey").Value;

            if (!Accesskey.Equals(keyValue))
                return false;
            return true;
        }
    }
}
