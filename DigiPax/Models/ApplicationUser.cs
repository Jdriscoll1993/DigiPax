
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DigiPax.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Username { get; set; }
    }
}