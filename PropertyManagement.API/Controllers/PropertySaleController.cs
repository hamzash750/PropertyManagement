using Microsoft.AspNetCore.Mvc;

namespace PropertyManagement.API.Controllers
{
    public class PropertySaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
