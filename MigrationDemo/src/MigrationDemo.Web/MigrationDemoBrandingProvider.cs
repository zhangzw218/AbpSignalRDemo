using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MigrationDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class MigrationDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MigrationDemo";
    }
}
