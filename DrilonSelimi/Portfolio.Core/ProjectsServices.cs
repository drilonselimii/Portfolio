using Databaza.DB;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Core
{
    public class ProjectsServices : IProjectsServices
    {
        private AppDbContext _context;
        public ProjectsServices(AppDbContext context)
        {
            _context = context;
        }

        public Project CreateProject(Project project)
        {
            _context.Add(project);
            _context.SaveChanges();

            return project;
        }

        public Project GetProject(int id)
        {
            return _context.Projects.First(n => n.projectId == id);
        }

        public List<Project> GetProjects()
        {
            return _context.Projects.ToList();
        }
        public void DeleteProject(int id)
        {
            var project = _context.Projects.First(n => n.projectId == id);
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }
        public void EditProject(Project project)
        {
            var editedProject = _context.Projects.First(n => n.projectId == project.projectId);
            editedProject.projectName = project.projectName;
            editedProject.ProjectLink = project.ProjectLink;
            _context.SaveChanges();
        }
    }
}
