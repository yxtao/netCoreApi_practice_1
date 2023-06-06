using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    // A DbContext instance represents a session with the database
    // and can be used to query and save instances of your entities
    public class MovieContext : DbContext  
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        // creates a DbSet<Movie> property for the entity set
        // an entity set typically corresponds to a database table and
        // an entity corresponds to a row in the table
        DbSet<Movie> Movies { get; set; }
    }
}
