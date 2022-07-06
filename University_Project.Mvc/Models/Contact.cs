using System.ComponentModel.DataAnnotations;

namespace University_Project.Mvc.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneN { get; set; }
        public string Comment { get; set; }
    }
}
