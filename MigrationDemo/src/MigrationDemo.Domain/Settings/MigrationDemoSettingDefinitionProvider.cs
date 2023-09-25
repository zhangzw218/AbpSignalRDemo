using Volo.Abp.Settings;

namespace MigrationDemo.Settings
{
    public class MigrationDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MigrationDemoSettings.MySetting1));
        }
    }
}
