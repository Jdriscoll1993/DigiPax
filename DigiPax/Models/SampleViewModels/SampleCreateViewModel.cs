using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiPax.Models.ViewModels
{
    public class SampleCreateViewModel
    {

        public int Id { get; set; }
        public Sample Sample { get; set; }
        public virtual IEnumerable<SelectListItem> MusicKeys { get; set; }
        public virtual IEnumerable<SelectListItem> SampleTypes { get; set; }
        public virtual IEnumerable<SelectListItem> Genres { get; set; }


    }
}
