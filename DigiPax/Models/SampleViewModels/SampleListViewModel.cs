using System.Collections.Generic;
using DigiPax.Models;
using DigiPax.Data;

namespace DigiPax.Models.SampleViewModels
{
    public class SampleListViewModel
    {
        public Sample Sample { get; set; }
        public IEnumerable<Key> Keys { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<SampleType> Types { get; set; }

    }
}
