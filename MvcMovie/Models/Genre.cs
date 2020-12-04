using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Genre
    {
        public int ID { get; set; }

        public string GenreName { get; set; }

        public DateTime StartDate { get; set; }

        public ICollection<Movie> Movie { get; set; }
    }
}