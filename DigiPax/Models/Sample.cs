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

        [Required]
        [Display(Name = "Type")]
        public int SampleTypeId { get; set; }
        [Display(Name = "Type")]
        public SampleType SampleType { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Key")]
        public int KeyId { get; set; }
        public Key Key { get; set; }




    }
}
