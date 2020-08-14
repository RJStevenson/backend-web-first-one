using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccessLibrary.DataAccess.PeopleMovieContext
{
    public class PeopleMovieContext : DbContext
    {
        public PeopleMovieContext(DbContextOptions options): base(options) { }
        public DbSet<Models.Movie.MovieModel> Movies { get; set; }
        public DbSet<Models.Genre.GenreModel> Genres { get; set; }
        public DbSet<Models.Person.PersonModel> People { get; set; }
        public DbSet<Models.Cart.CartModel> Carts { get; set; }
    }
}
