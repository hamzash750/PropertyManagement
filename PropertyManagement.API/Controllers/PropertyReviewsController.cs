using Microsoft.AspNetCore.Mvc;

namespace PropertyManagement.API.Controllers
{
    public class PropertyReviewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
