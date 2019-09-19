using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiPax.Models.ViewModels
{
    public class PackDetailsViewModel
    {
        public int Id { get; set; }
        public Pack Pack { get; set; }
        public virtual ICollection<Sample> PackSamples { get; set; }

    }
}
