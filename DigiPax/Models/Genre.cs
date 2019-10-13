using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiPax.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sample> Samples { get; set; }
    }
}
