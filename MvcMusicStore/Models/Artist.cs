using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Artist
    {
        public int Id { get; set; }

        [Display(Name="Artist")]
        public string Name { get; set; }
    }
}