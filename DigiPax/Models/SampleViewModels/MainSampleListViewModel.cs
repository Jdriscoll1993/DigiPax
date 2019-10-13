using X.PagedList;

namespace DigiPax.Models.ViewModels
{
    public class MainSampleListViewModel
    {
        public IPagedList<Sample> Sample { get; set; }
        public bool IsFavorite { get; set; }
    }
}
