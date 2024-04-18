using ForcegetSoft.Application.Services.Incoterm;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForcegetSoft.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class IncotermController : ControllerBase
    {
        private readonly IIncotermService _incotermService;

        public IncotermController(IIncotermService incotermService)
        {
            _incotermService = incotermService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_incotermService.GetIncoterms());
        }
    }
}
