using ES.Data.Config;
using ES.Data.Identity;
using ES.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ES.Data.Core
{
    public class EstateSystemDbContext : IdentityDbContext<EstateSystemIdentityUser>
    {
        public DbSet<Estate> Estates { get; set; }

        public EstateSystemDbContext(DbContextOptions<EstateSystemDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EstateConfig());

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}