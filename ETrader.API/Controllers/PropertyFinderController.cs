using Microsoft.AspNetCore.Mvc;

namespace ETrader.API.Controllers
{
    public class PropertyFinderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
