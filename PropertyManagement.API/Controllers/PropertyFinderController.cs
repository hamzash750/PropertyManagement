using Microsoft.AspNetCore.Mvc;

namespace PropertyManagement.API.Controllers
{
    public class PropertyFinderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
