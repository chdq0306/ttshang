using ttshang.thingmodel.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ttshang.thingmodel.Permissions;

public class thingmodelPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(thingmodelPermissions.GroupName, L("Permission:thingmodel"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<thingmodelResource>(name);
    }
}
