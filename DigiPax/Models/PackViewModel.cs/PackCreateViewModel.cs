using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigiPax.Models.ViewModels
{
    public class PackCreateViewModel
    {
        public int Id { get; set; }
        public Pack Pack { get; set; }
        public List<int> SampleIds { get; set; }
    }
}
