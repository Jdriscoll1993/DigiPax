using DigiPax.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigiPax.Models
{
    public class Sample
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        [Display(Name = "Sample Name")]
        public string SampleName { get; set; }
        public string SamplePath { get; set; }

        [Required]
        [Display(Name = "Author")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "Type")]
        public int SampleTypeId { get; set; }
        [Display(Name = "Type")]
        public SampleType SampleType { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Key")]
        public int MusicKeyId { get; set; }
        public MusicKey MusicKey { get; set; }

        public int BPM { get; set; }

        public bool? isFavorite { get; set; }

        public ICollection<PackSample> PackSamples { get; set; }




    }
}
