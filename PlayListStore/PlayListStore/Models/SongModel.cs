using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayListStore.Models
{
    public class SongModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Singer { get; set; }
        public string Writer { get; set; }
        public string Year { get; set; }

        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public IEnumerable<SelectListItem> Genres { get; set; }

        public SongModel()
        {
            Genres = new List<SelectListItem>();
        }
    }
}