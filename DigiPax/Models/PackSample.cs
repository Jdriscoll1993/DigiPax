using System.ComponentModel.DataAnnotations;

namespace DigiPax.Models
{
    public class PackSample
    {
        [Key]
        public int Id { get; set; }

        public int PackId { get; set; }
        public Pack Pack { get; set; }

        public int SampleId { get; set; }
        public Sample Sample { get; set; }
    }
}
