using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ETrader.Business.Interface;
using ETrader.DAL.Model;

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
        [HttpPost, Route("PostAdd")]
        public IActionResult PostAdd(PropertyAds obj)
        {
            if (_propertyAddService.SaveProperty(obj)>0)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet, Route("GetLatestProperty")]
        public IActionResult GetLatestProperty()
        {
            var propertyList = _propertyAddService.getLatestofProperty();
            return Ok(propertyList);
        }
        [HttpGet, Route("AgentPropertyList")]
        public IActionResult AgentPropertyList(int Id)
        {
            var propertyList = _propertyAddService.getAgentPropertyList(Id);
            return Ok(propertyList);
        }
        [HttpDelete, Route("DeleteProperty")]
        public IActionResult DeleteProperty(int Id)
        {
            var propertyList = _propertyAddService.deleteProperty(Id);
            return Ok(propertyList);
        }
        [HttpGet, Route("BuyerPropertyList")]
        public IActionResult BuyerPropertyList(int Id)
        {
            var propertyList = _propertyAddService.getBuyerPropertyList(Id);
            return Ok(propertyList);
        }
        [HttpGet, Route("UserDashboardDetails")]
        public IActionResult UserDashboardDetails(int Id)
        {
            var propertyList = _propertyAddService.GetUserDashboardData(Id);
            return Ok(propertyList);
        }
        [HttpGet, Route("UserChatList")]
        public IActionResult UserChatList(int Id)
        {
            var propertyList = _propertyAddService.GetUserChatList(Id);
            return Ok(propertyList);
        }
        [HttpGet, Route("UserChatDetails")]
        public IActionResult UserChatDetails(int Id,int buyerId)
        {
            var propertyList = _propertyAddService.GetUserChatDetails(Id,buyerId);
            return Ok(propertyList);
        }
        [HttpPost, Route("SaveNewMessage")]
        public IActionResult SaveNewMessage(PropertyChat obj)
        {
            if (_propertyAddService.saveNewMessage(obj) > 0)
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
