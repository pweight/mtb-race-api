using Microsoft.EntityFrameworkCore;

namespace mtb_race_api.Infrastructure
{
    public class RaceDbContext : DbContext
    {
        public RaceDbContext(DbContextOptions<RaceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Race> Races { get; set; } = null!;
    }
}