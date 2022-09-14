using Microsoft.AspNetCore.Mvc;

namespace ETrader.API.Controllers
{
    public class UserManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
