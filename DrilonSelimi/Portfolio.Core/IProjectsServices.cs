using Databaza.DB;
using System.Collections.Generic;

namespace Portfolio.Core
{
    public interface IProjectsServices
    {
        Project CreateProject(Project project);

        Project GetProject(int id);
        List<Project> GetProjects();

        void DeleteProject(int id);
    }
}
