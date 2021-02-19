using System.ComponentModel.DataAnnotations;

namespace Databaza.DB
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        public string user { get; set; }
        public string password { get; set; }
    }
}
