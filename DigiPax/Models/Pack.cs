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
        public PackSample PackSample { get; set; }
        public int UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
