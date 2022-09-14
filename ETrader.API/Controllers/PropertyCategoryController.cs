using Microsoft.AspNetCore.Mvc;

namespace ETrader.API.Controllers
{
    public class PropertyCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
