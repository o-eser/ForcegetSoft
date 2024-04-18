using ForcegetSoft.Application.Services.Unit1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForcegetSoft.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class Unit1Controller : ControllerBase
    {
        private readonly IUnit1Service _unit1Service;

        public Unit1Controller(IUnit1Service unit1Service)
        {
            _unit1Service = unit1Service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unit1Service.GetUnit1s());
        }
    }
}
