using System.ComponentModel.DataAnnotations;

namespace University_Project.Mvc.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
    }
}
