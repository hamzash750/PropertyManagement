using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ETrader.Business.Interface;

namespace ETrader.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyAddService _propertyAddService;
        private IConfiguration configuration;
        public PropertyController(IPropertyAddService propertyAddService, IConfiguration configuration)
        {
            _propertyAddService = propertyAddService;
            this.configuration = configuration;
        }
        [HttpGet, Route("GetAllProperty")]
        public IActionResult AllPropertyList()
        {
            var propertyList = _propertyAddService.getListofProperty();
            return Ok(propertyList);
        }
        [HttpGet, Route("PropertyDetails")]
        public IActionResult PropertyDetails(int Id)
        {
            var propertyList = _propertyAddService.GetPropertyDetails(Id);
            return Ok(propertyList);
        }
        [HttpGet, Route("PropertyReviews")]
        public IActionResult PropertyReviews(int Id)
        {
            var propertyList = _propertyAddService.GetProductReview(Id);
            return Ok(propertyList);
        }
        [HttpGet, Route("PropertyCategoryList")]
        public IActionResult PropertyCategoryList(int Id)
        {
            var propertyList = _propertyAddService.getListofCategory(Id);
            return Ok(propertyList);
        }
    }
}
