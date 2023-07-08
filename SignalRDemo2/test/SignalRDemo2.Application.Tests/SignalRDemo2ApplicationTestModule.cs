using Volo.Abp.Modularity;

namespace SignalRDemo2;

[DependsOn(
    typeof(SignalRDemo2ApplicationModule),
    typeof(SignalRDemo2DomainTestModule)
    )]
public class SignalRDemo2ApplicationTestModule : AbpModule
{

}
