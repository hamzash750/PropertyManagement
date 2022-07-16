using Microsoft.AspNetCore.Mvc;

namespace PropertyManagement.API.Controllers
{
    public class UserManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
