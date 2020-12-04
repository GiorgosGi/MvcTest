using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }

        [Display(Name ="ReleaseDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyy-mm-dd}",ApplyFormatInEditMode=true)]
        public DateTime ReleaseDate { get; set; }

        public string GenreName { get; set; }

        public decimal Price { get; set; }

        public int GenreID { get; set; }
        public Genre Genre { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}