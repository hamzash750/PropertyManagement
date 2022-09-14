using Microsoft.AspNetCore.Mvc;

namespace ETrader.API.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
