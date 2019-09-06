
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DigiPax.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Screen Name")]

        public string ScreenName { get; set; }
    }
}