
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiPax.Models
{
    // Implement IdentityUser
    public class ApplicationUser : IdentityUser
    {
        //Users are prompted to login with Screen Name instead of default option of Email
        [Required]
        [Display(Name = "Screen Name")]
        public string ScreenName { get; set; }

        public virtual ICollection<Sample> Samples { get; set; }
        public virtual ICollection<Pack> Packs { get; set; }

    }
}