using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MigrationDemo.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class MigrationDemoMigrationsDbContextFactory : IDesignTimeDbContextFactory<MigrationDemoMigrationsDbContext>
    {
        public MigrationDemoMigrationsDbContext CreateDbContext(string[] args)
        {
            MigrationDemoEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();
            var mySqlConn = configuration.GetConnectionString("Default");
            var builder = new DbContextOptionsBuilder<MigrationDemoMigrationsDbContext>()
                .UseMySql(mySqlConn, MySqlServerVersion.LatestSupportedServerVersion);

            return new MigrationDemoMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MigrationDemo.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
