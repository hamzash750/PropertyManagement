using Microsoft.AspNetCore.Mvc;

namespace PropertyManagement.API.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
