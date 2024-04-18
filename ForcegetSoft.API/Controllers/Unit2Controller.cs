using ForcegetSoft.Application.Services.Unit2;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForcegetSoft.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class Unit2Controller : ControllerBase
    {
        private readonly IUnit2Service _unit2Service;

        public Unit2Controller(IUnit2Service unit2Service)
        {
            _unit2Service = unit2Service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unit2Service.GetUnit2s());
        }
    }
}
