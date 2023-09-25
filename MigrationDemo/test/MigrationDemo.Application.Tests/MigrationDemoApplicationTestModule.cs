using Volo.Abp.Modularity;

namespace MigrationDemo
{
    [DependsOn(
        typeof(MigrationDemoApplicationModule),
        typeof(MigrationDemoDomainTestModule)
        )]
    public class MigrationDemoApplicationTestModule : AbpModule
    {

    }
}