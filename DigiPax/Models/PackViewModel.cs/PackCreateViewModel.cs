using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiPax.Models.ViewModels
{
    public class PackCreateViewModel
    {
        public int Id { get; set; }
        public PackSample PackSample { get; set; }
        public Pack Pack { get; set; }
        public Sample Sample { get; set; }
        public virtual IEnumerable<SelectListItem> Samples { get; set; }
    }
}
