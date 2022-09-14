using Microsoft.AspNetCore.Mvc;

namespace ETrader.API.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
