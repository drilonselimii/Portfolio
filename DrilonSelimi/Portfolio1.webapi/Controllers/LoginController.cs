using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Core;
using Databaza.DB;

namespace Portfolio1.webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly ILogger<LoginController> _logger;
        private IAdminsServices _adminsServices;

        public LoginController(ILogger<LoginController> logger, IAdminsServices adminsServices)
        {
            _logger = logger;
            _adminsServices = adminsServices;
        }

        [HttpGet("{id}", Name = "GetAdmin")]
        public IActionResult GetAdmin(int id)
        {
            return Ok(_adminsServices.GetAdmin(id));

        }

        [HttpGet]
        public IActionResult GetAdmins()
        {
            return Ok(_adminsServices.GetAdmins()); }


        [HttpPost]
        public IActionResult CreateAdmin(Admin admin)
        {
            var newAdmin = _adminsServices.CreateAdmin(admin);
            return CreatedAtRoute("GetAdmin", new { newAdmin.Id }, newAdmin);

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAdmin(int id)
        {
            _adminsServices.DeleteAdmin(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult EditAdmin([FromBody] Admin admin )
        {
            _adminsServices.EditAdmin(admin);
            return Ok();
        }
    }
}
