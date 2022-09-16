using ETrader.Business.Interface;
using ETrader.DAL.Model;
using ETrader.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ETrader.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyFinderController : Controller
    {
        private readonly IPropertyAddService _propertyAddService;
        private IConfiguration configuration;
        public PropertyFinderController(IPropertyAddService propertyAddService, IConfiguration configuration)
        {
            _propertyAddService = propertyAddService;
            this.configuration = configuration;
        }

        [HttpGet, Route("GetAllFinderRequest")]
        public IActionResult GetAllFinderRequest()
        {
            var propertyList = _propertyAddService.getAllRequest();
            return Ok(propertyList);
        }
        [HttpPost, Route("NewRequest")]
        public IActionResult NewRequest(PropertyFinder obj)
        {
            if (_propertyAddService.postFinderRequest(obj)>0)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet, Route("GetUserFinderRequest")]
        public IActionResult GetUserFinderRequest(int Id)
        {
            var propertyList = _propertyAddService.getAllUserRequest(Id);
            return Ok(propertyList);
        }
        [HttpDelete, Route("DeleteRequest")]
        public IActionResult DeleteRequest(int Id)
        {
            var propertyList = _propertyAddService.deleteRequest(Id);
            return Ok(propertyList);
        }
    }
}
