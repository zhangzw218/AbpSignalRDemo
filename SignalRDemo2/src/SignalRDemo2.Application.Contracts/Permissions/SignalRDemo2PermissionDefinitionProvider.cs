using SignalRDemo2.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SignalRDemo2.Permissions;

public class SignalRDemo2PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SignalRDemo2Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SignalRDemo2Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SignalRDemo2Resource>(name);
    }
}
