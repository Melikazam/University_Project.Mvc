using System.ComponentModel.DataAnnotations;

namespace University_Project.Mvc.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
