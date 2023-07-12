using Microsoft.EntityFrameworkCore;

namespace blazorblog.Data
{
    /* <+> the ':' means A extends B */
    public class BbDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public BbDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("BbDatabase"));
        }
        public DbSet<Post> Posts {get;set;}   
    }
}