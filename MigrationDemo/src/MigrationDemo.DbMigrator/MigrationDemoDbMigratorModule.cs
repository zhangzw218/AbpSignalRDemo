using MigrationDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MigrationDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MigrationDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(MigrationDemoApplicationContractsModule)
        )]
    public class MigrationDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
