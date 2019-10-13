using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiPax.Models
{
    public class Pack
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Display(Name = "Sample")]
        public ICollection<PackSample> PackSamples { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
