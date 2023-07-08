using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SignalRDemo2.Web;

[Dependency(ReplaceServices = true)]
public class SignalRDemo2BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SignalRDemo2";
}
