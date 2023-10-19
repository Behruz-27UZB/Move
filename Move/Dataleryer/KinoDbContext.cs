using Microsoft.EntityFrameworkCore;
using Move.Model;

namespace Move.Dataleryer
{
    public class KinoDbContext:DbContext
    {
        public KinoDbContext(DbContextOptions<KinoDbContext> options)
            : base(options) { }


        public DbSet<User> Users { get; set; }
        public DbSet<Moveis> Moveiss { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
