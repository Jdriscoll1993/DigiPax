using System.ComponentModel.DataAnnotations;

namespace DigiPax.Models
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int SampleId { get; set; }
        public Sample Sample { get; set; }
    }
}
