using ETrader.Business.Interface;
using ETrader.DAL.Model;
using ETrader.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Stripe;

namespace ETrader.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : Controller
    {
        private readonly IPropertyAddService _propertyAddService;
        private IConfiguration configuration;
        public PaymentController(IPropertyAddService propertyAddService, IConfiguration configuration)
        {
            _propertyAddService = propertyAddService;
            this.configuration = configuration;
        }
        [HttpPost, Route("PostPaymentToken")]
        public IActionResult PostPaymentToken(PaymentVM obj)
        {
            StripeConfiguration.ApiKey = "sk_test_pJFRTheV3HrMRcGa7UuyLJN000NSBlxDs1";

            // Token is created using Checkout or Elements!
            // Get the payment token submitted by the form:

            var options = new ChargeCreateOptions
            {
                Amount = obj.Amount,
                Currency = "usd",
                Description = obj.Product,
                Source = obj.Token,
            };
            var service = new ChargeService();
            var charge = service.Create(options);
            var ps = new PropertySale();
            ps.BuyerId = obj.BuyerId;
            ps.PaidAmount = obj.Amount;
            ps.PropertyId = obj.PropertyId;
            ps.PurchaseDase = System.DateTime.Now;
            ps.Qty = 1;
            ps.SellerId = obj.SellerId;
            ps.TransactionId = charge.BalanceTransactionId;
            _propertyAddService.SavePropertySale(ps);
            return Ok();
        }
    }
}
