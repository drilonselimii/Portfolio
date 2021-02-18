using System.ComponentModel.DataAnnotations;

namespace PortfolioDb.DB
{
    public class Resume
    {
        [Key]
        public int Id { get; set; }

        public string Value { get; set; }
    }
}
