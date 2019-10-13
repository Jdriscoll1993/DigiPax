using System.Collections.Generic;

namespace DigiPax.Models.ViewModels
{
    public class PackCreateViewModel
    {
        public int Id { get; set; }
        public Pack Pack { get; set; }
        public List<int> SampleIds { get; set; }
    }
}
