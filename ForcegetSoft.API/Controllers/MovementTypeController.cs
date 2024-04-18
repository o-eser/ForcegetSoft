using ForcegetSoft.Application.Services.MovementType;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForcegetSoft.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MovementTypeController : ControllerBase
    {
        private readonly IMovementTypeService _movementTypeService;

        public MovementTypeController(IMovementTypeService movementTypeService)
        {
            _movementTypeService = movementTypeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_movementTypeService.GetMovementTypes());
        }
    }
}
