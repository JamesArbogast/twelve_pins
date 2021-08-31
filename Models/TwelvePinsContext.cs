using Microsoft.EntityFrameworkCore;

namespace twelve_pins.Models
{
    public class TwelvePinsContext : DbContext
    {
        public TwelvePinsContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Lane> Lanes { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<League> Leagues { get; set; }
    }
}
