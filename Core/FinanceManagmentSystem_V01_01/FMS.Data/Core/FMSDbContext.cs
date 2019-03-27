using FMS.Data.Identity;
using FMS.Models.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Data.Core
{
    public class FMSDbContext : IdentityDbContext<FMSIdentityUser>
    {
        public FMSDbContext(DbContextOptions<FMSDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(this.SeedDefaultRoles());

            this.ApplyModelConfigurations(builder);

            this.SeedDefaultAdmin(builder);

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ApplyAuditInfoRules();
            this.ApplyDeletionRules();

            return base.SaveChangesAsync(cancellationToken);
        }

        private void ApplyDeletionRules()
        {
            var entitiesForDeletion = this.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Deleted && e.Entity is IDeletable);

            foreach (var entry in entitiesForDeletion)
            {
                var entity = (IDeletable)entry.Entity;
                entity.DeletedOn = DateTime.Now;
                entity.IsDeleted = true;
                entry.State = EntityState.Modified;
            }
        }

        private void ApplyAuditInfoRules()
        {
            var newlyCreatedEntities = this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModifiable && ((e.State == EntityState.Added) || (e.State == EntityState.Modified)));

            foreach (var entry in newlyCreatedEntities)
            {
                var entity = (IModifiable)entry.Entity;

                if (entry.State == EntityState.Added && entity.CreatedOn == null)
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }

        private void ApplyModelConfigurations(ModelBuilder builder)
        {
            
        }

        private IdentityRole[] SeedDefaultRoles()
        {
            var administrator = new IdentityRole() { Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" };
            //var player = new IdentityRole() { Id = "2", Name = "Personal", NormalizedName = "Personal" };

            return new IdentityRole[] { administrator };
        }

        private void SeedDefaultAdmin(ModelBuilder builder)
        {
            var adminUser = new FMSIdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Admin",
                NormalizedUserName = "admin@mail.com".ToUpper(),
                Email = "admin@mail.com",
                TwoFactorEnabled = false,
                NormalizedEmail = "admin@mail.com".ToUpper(),
                EmailConfirmed = true,
                PhoneNumber = "+359359",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                AccessFailedCount = 0,
                LockoutEnabled = false
            };

            var hashePass = new PasswordHasher<FMSIdentityUser>().HashPassword(adminUser, "!Aa12345678");
            adminUser.PasswordHash = hashePass;

            builder.Entity<FMSIdentityUser>().HasData(adminUser);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = 1.ToString(),
                UserId = adminUser.Id
            });
        }
    }
}