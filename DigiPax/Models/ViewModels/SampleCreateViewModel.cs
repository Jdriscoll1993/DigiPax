using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiPax.Models.ViewModels
{
    public class SampleCreateViewModel
    {
        public Sample Sample {get; set;}
        public List<Sample> Samples { get; set; }
        public List<Key> Keys { get; set; }
        public List<Genre> Genres { get; set; }
        public List<SampleType> Types { get; set; }

    }
}
