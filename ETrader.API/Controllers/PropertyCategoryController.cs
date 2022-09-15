using ETrader.Business.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ETrader.API.Controllers
{
    public class PropertyCategoryController : Controller
    {
        private readonly IPropertyAddService _propertyAddService;
        private IConfiguration configuration;
        public PropertyCategoryController(IPropertyAddService propertyAddService, IConfiguration configuration)
        {
            _propertyAddService = propertyAddService;
            this.configuration = configuration;
        }

        [HttpGet, Route("GetAllPropertyCategory")]
        public IActionResult AllPropertyCategoryList()
        {
            var propertyList = _propertyAddService.getListOfPropertyCategory();
            return Ok(propertyList);
        }
    }
}
