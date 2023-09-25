using MigrationDemo.Test;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MigrationDemo.EntityFrameworkCore
{
    public static class MigrationDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureMigrationDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MigrationDemoConsts.DbTablePrefix + "YourEntities", MigrationDemoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});


        builder.Entity<TempRole>(b =>
        {
            b.ToTable(MigrationDemoConsts.DbTablePrefix + "TempRoles", MigrationDemoConsts.DbSchema);
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });
        }
    }
}
