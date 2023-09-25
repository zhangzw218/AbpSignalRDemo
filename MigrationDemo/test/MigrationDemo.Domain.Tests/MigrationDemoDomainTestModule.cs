using MigrationDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MigrationDemo
{
    [DependsOn(
        typeof(MigrationDemoEntityFrameworkCoreTestModule)
        )]
    public class MigrationDemoDomainTestModule : AbpModule
    {

    }
}