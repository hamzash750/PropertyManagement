
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ETrader.Business.Interface;
using ETrader.ViewModel;
using System.Net;

namespace ETrader.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorizationController : ControllerBase
    {
        private readonly IAuthorizationService _authorizationService;
        private IConfiguration configuration;
        public AuthorizationController(IAuthorizationService AuthorizationService, IConfiguration configuration)
        {
            _authorizationService = AuthorizationService;
            this.configuration = configuration;
        }
        [HttpPost, Route("Register")]
        public IActionResult RegisterNewUser(RegisterVM obj)
        {
            if (_authorizationService.Regsiter(obj))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost, Route("Login")]
        public IActionResult LoginNewUser(RegisterVM obj)
        {
            var login = _authorizationService.Login(obj);
            return Ok(login);
        }
        [HttpGet, Route("UserDetails")]
        public IActionResult FindUserDetails(int Uid)
        {
            var accessKey = HttpContext.Request.Headers["AccessKey"];
            if (!_authorizationService.checkAccessKey(accessKey))
            {
                return Unauthorized("Exited early. The AccessKey is invalid.");
            }

            var login = _authorizationService.UserDetails(Uid);
            return Ok(login);
        }
       
    }
}
