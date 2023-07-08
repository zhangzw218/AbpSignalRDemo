using SignalRDemo2.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SignalRDemo2.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SignalRDemo2EntityFrameworkCoreModule),
    typeof(SignalRDemo2ApplicationContractsModule)
    )]
public class SignalRDemo2DbMigratorModule : AbpModule
{

}
