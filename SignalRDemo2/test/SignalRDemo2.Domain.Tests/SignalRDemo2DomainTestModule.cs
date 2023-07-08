using SignalRDemo2.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SignalRDemo2;

[DependsOn(
    typeof(SignalRDemo2EntityFrameworkCoreTestModule)
    )]
public class SignalRDemo2DomainTestModule : AbpModule
{

}
