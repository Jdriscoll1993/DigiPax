
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiPax.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Screen Name")]
        public string ScreenName { get; set; }

        public virtual ICollection<Sample> Samples { get; set; }
        public virtual ICollection<Pack> Packs { get; set; }

    }
}