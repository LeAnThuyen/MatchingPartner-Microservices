using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {


        }
        public DbSet<PlatForm> platForms { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PlatForm>().ToTable("Platform");
            builder.Entity<PlatForm>().Property(c => c.Id).UseIdentityColumn();
        }
    }
}
