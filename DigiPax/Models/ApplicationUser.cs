
using Microsoft.AspNetCore.Identity;

namespace DigiPax.Data
{
    public class ApplicationUser : IdentityUser
    {
        public int Username { get; set; }
    }
}