using Microsoft.AspNetCore.Mvc;

namespace PropertyManagement.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
