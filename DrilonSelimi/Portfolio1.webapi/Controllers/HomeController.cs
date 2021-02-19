using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Core;
using Databaza.DB;

namespace Portfolio1.webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        
        private readonly ILogger<HomeController> _logger;
        private IAboutmeServices _aboutmeServices;

        public HomeController(ILogger<HomeController> logger, IAboutmeServices aboutmeServices)
        {
            _logger = logger;
            _aboutmeServices = aboutmeServices;
        }

        [HttpGet("{id}", Name = "GetAboutme")]
        public IActionResult GetAboutme(int id)
        {
            return Ok(_aboutmeServices.GetAboutme(id));

        }

        [HttpPut]
        public IActionResult EditAboutme([FromBody] Aboutme aboutme)
        {
            _aboutmeServices.EditAboutme(aboutme);
            return Ok();
        }
    }
}
