using ETrader.Business.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ETrader.API.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _UserService;
        private IConfiguration configuration;
        public UserController(IUserService userService, IConfiguration configuration)
        {
            _UserService = userService;
            this.configuration = configuration;
        }

        [HttpGet, Route("GetAllAgent")]
        public IActionResult AllPropertyCategoryList()
        {
            var propertyList = _UserService.getAllAgent();
            return Ok(propertyList);
        }
    }
}
