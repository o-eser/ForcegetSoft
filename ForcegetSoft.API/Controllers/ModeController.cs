using ForcegetSoft.Application.Services.Mode;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForcegetSoft.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ModeController : ControllerBase
    {
        private readonly IModeService _modeService;

        public ModeController(IModeService modeService)
        {
            _modeService = modeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_modeService.GetModes());
        }
    }
}
