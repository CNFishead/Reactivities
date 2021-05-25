using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    //Derive from the entity core framework the DbContext
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // This will represent a table in the database the properties inside the table
        // Will be based on the Activity Class.
        public DbSet<Activity> Activities { get; set; }
    }
}