using System.Collections.Generic;

namespace DigiPax.Models.ViewModels
{
    public class FavoriteListViewModel
    {
        public IEnumerable<Favorite> Favorites { get; set; }
        public IEnumerable<Sample> Samples { get; set; }
    }
}
