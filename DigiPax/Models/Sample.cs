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
        public int Id { get; set; }
        public string SampleName { get; set; }
        public string SamplePath { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


        public int TypeId { get; set; }
        public SampleType SampleType { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public int KeyId { get; set; }
        public Key Key { get; set; }




    }
}
