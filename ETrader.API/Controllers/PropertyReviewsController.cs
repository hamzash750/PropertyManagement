using ETrader.Business.Interface;
using ETrader.DAL.Model;
using ETrader.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ETrader.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyReviewsController : Controller
    {
        private readonly IPropertyAddService _propertyAddService;
        private IConfiguration configuration;
        public PropertyReviewsController(IPropertyAddService propertyAddService, IConfiguration configuration)
        {
            _propertyAddService = propertyAddService;
            this.configuration = configuration;
        }

        [HttpPost, Route("AddPropertyReview")]
        public IActionResult AddPropertyReview(PropertyReviews obj)
        {
            if (_propertyAddService.postPropertyReview(obj) > 0)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}