using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigiPax.Models
{
    public class Key
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
