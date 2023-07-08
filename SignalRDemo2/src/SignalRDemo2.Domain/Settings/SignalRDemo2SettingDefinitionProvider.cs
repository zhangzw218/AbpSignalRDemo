using Volo.Abp.Settings;

namespace SignalRDemo2.Settings;

public class SignalRDemo2SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SignalRDemo2Settings.MySetting1));
    }
}
