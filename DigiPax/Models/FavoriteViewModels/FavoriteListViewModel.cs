﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiPax.Models.ViewModels
{
    public class FavoriteListViewModel
    {
        public IEnumerable<Sample> Favorites { get; set; }
        public IEnumerable<Sample> Samples { get; set; }
    }
}