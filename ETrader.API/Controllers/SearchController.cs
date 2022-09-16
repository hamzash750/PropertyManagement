using ETrader.Business.Interface;
using ETrader.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ETrader.API.Controllers
{
    [ApiController]
    public class SearchController : Controller
    {
        private readonly IPropertyAddService _propertyAddService;
        private IConfiguration configuration;
        public SearchController(IPropertyAddService propertyAddService, IConfiguration configuration)
        {
            _propertyAddService = propertyAddService;
            this.configuration = configuration;
        }

        [HttpPost, Route("SearchProperty")]
        public IActionResult SearchProperty(SearchVM obj)
        {
            var propertyList = _propertyAddService.searchProperty(obj);
            return Ok(propertyList);
        }
    }
}
