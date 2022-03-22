using ChildTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ChildTest.Permissions;

public class ChildTestPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ChildTestPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ChildTestPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ChildTestResource>(name);
    }
}
