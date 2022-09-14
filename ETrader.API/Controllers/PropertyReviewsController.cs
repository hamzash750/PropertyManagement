using Microsoft.AspNetCore.Mvc;

namespace ETrader.API.Controllers
{
    public class PropertyReviewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
