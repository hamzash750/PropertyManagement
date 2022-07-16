using Microsoft.AspNetCore.Mvc;

namespace PropertyManagement.API.Controllers
{
    public class PropertyCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
