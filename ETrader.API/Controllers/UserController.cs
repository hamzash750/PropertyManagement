using Microsoft.AspNetCore.Mvc;

namespace ETrader.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
