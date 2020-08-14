using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLibrary.Models.Cart
{
    public class CartModel
    {
        [Key]
        public int CartID { get; set; }
        public Person.PersonModel PersonID { get; set; }
        public DateTime DateMade { get; set; }
        public List<Movie.MovieModel> Movies { get; set; } = new List<Movie.MovieModel>();
        public bool HasPayed { get; set; }

    }
}
