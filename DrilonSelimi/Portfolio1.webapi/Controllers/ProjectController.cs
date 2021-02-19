using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Core;
using Databaza.DB;

namespace Portfolio1.webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {

        private readonly ILogger<ProjectController> _logger;
        private IProjectsServices _projectsServices;

        public ProjectController(ILogger<ProjectController> logger, IProjectsServices projectsServices)
        {
            _logger = logger;
            _projectsServices = projectsServices;
        }

        [HttpGet("{id}", Name = "GetProject")]
        public IActionResult GetProject(int id)
        {
            return Ok(_projectsServices.GetProject(id));

        }

        [HttpGet]
        public IActionResult GetProjects()
        {
            return Ok(_projectsServices.GetProjects()); }


        [HttpPost]
        public IActionResult CreateProject(Project project)
        {
            var newProject = _projectsServices.CreateProject(project);
            return CreatedAtRoute("GetProject", new { newProject.projectId }, newProject);

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProject(int id)
        {
            _projectsServices.DeleteProject(id);
            return Ok();
        }
        
    }
}
