using System.ComponentModel.DataAnnotations;

namespace University_Project.Mvc.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int Stock { get; set; }
    }
}
