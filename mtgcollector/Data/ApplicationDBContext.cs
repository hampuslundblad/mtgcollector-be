using Microsoft.EntityFrameworkCore;
using mtgcollector.Models;

namespace mtgcollector.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Card> Card { get; set; }
        public DbSet<Collection> Collection { get; set; }
    }
}