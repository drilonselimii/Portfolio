using System.ComponentModel.DataAnnotations;


namespace Databaza.DB
{
    public class Project
    {
        [Key]
        public int projectId { get; set; }

        public string projectName { get; set; }
        public string ProjectLink { get; set; }
    }
}
