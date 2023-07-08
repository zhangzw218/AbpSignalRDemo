using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SignalRDemo2.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SignalRDemo2DbContextFactory : IDesignTimeDbContextFactory<SignalRDemo2DbContext>
{
    public SignalRDemo2DbContext CreateDbContext(string[] args)
    {
        SignalRDemo2EfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SignalRDemo2DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SignalRDemo2DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SignalRDemo2.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
