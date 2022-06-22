using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace University_Project.Mvc.Areas.Identity.Data
{
    public class User : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "varchar(70)")]
        public string LastName { get; set; }
        [PersonalData]
        [Column(TypeName = "int")]
        public int? AddressId { get; set; }
    }
}
