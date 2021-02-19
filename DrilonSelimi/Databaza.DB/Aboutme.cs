using System.ComponentModel.DataAnnotations;


namespace Databaza.DB
{
    public class Aboutme
    {
        [Key]
        public int aboutmeId { get; set; }

        public string text { get; set; }
       
    }
}
