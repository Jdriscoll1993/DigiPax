using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiPax.Models.ViewModels
{
    public class FavoriteDetailsViewModel
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public string SamplePath { get; set; }
        public Sample Sample { get; set; }

        public Genre Genre { get; set; }
        public int GenreId { get; set; }

        public SampleType SampleType { get; set; }
        public int SampleTypeId { get; set; }

        public MusicKey MusicKey { get; set; }
        public int MusicKeyId { get; set; }

        public Favorite Favorite { get; set; }
        public int FavoriteId { get; set; }



    }
}
