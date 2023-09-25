using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MigrationDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(MigrationDemoEntityFrameworkCoreModule)
        )]
    public class MigrationDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MigrationDemoMigrationsDbContext>();
        }
    }
}
