using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DrilonSelimi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResumeController : ControllerBase
    {
        
        private readonly ILogger<ResumeController> _logger;

        public ResumeController(ILogger<ResumeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Resume");
        }
    }
}
