using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace DigiPax.Models.ViewModels
{
    public class MainSampleListViewModel
    {
        public IPagedList<Sample> Sample { get; set; }
        public bool IsFavorite { get; set; }
    }
}
