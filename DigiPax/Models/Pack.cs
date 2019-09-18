using DigiPax.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigiPax.Models
{
    public class Pack
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name = "Sample")]
        public ICollection<PackSample> PackSample { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


    }
}
