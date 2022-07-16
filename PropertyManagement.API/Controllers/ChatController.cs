using Microsoft.AspNetCore.Mvc;

namespace PropertyManagement.API.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
