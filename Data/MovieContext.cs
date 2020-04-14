using Microsoft.EntityFrameworkCore;
using MvcMovies.Models;

namespace MvcMovies.Data
{
  public class MovieContext : DbContext
  {
    public MovieContext (DbContextOptions<MovieContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; }
  }
}
