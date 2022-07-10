using System.ComponentModel.DataAnnotations;
using University_Project.Mvc.Enums;

namespace University_Project.Mvc.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public byte[] Image { get; set; }
        public CategoryEnum Category_Id { get; set; }
    }
}
