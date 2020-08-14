using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLibrary.Models.Genre
{
    public class GenreModel
    {
        [Key]
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        // public int MovieID { get; set; }
    }
}
