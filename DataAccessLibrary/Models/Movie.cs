
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace DataAccessLibrary.Models.Movie
{
    
    public class MovieModel
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public List<Genre.GenreModel> Genres { get; set; } = new List<Genre.GenreModel>();
    }

  
}