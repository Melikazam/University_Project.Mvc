using Microsoft.AspNetCore.Http;

namespace University_Project.Mvc.Models
{
    public class ProductFormViewModel
    {
        public string Name { get; set; }
        public decimal price { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public int Category_Id { get; set; }
    }
}
