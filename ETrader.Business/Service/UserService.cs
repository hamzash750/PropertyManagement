using ETrader.Business.Interface;
using ETrader.DAL;
using ETrader.DAL.Model;
using ETrader.ViewModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            return context.Users.Where(x => x.UType == "S").ToList();
        }

        public void sendAdminEmail(ContactUsVM obj)
        {
            StringBuilder body = new StringBuilder();
            body.Append("Hi Admin <br>");
            body.Append("Mr " + obj.Name + " Make contact request <br>");
            body.Append("User Details <br> Phone" + obj.Phone + "<br> Email " + obj.Email);
            body.Append("<br> User Message " + obj.Message);
            body.Append("<br> Regard's <br> Etrader dAdmin Support");
            SendEmail("Contact Us Email", body.ToString());
        }
        public static void SendEmail(string subject, string body)
        {
            string senderMail = "admin@christianhalltv.com";
            string senderPass = "Chtv2021*";
            string MailHostServer = "mail.christianhalltv.com";
            string port = "25";
            string displayName = subject;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderMail, displayName);

            mail.To.Add("khateebtalib085@gmail.com");
            mail.Subject = subject;

            mail.IsBodyHtml = true;
            mail.Body = body;


            mail.Priority = MailPriority.Normal;

            var stmp = new SmtpClient();
            stmp.Credentials = new NetworkCredential(senderMail, senderPass);
            stmp.Host = MailHostServer;
            stmp.Port = Convert.ToInt32(port);
            stmp.EnableSsl = false;
            stmp.Send(mail);
        }
    }
}
