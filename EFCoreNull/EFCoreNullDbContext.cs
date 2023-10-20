using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;
using EFCoreNull.Repo;

namespace EFCoreNull
{
    public class EFCoreNullDbContext : AbpDbContext<EFCoreNullDbContext>
    {
        public EFCoreNullDbContext(DbContextOptions<EFCoreNullDbContext> options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users");
                b.ConfigureByConvention();
                b.ConfigureAbpUser();
                b.HasOne<IdentityUser>().WithOne().HasForeignKey<IdentityUser>(a => a.Id);
            });

            builder.ConfigureIdentity();
        }
    }
}
