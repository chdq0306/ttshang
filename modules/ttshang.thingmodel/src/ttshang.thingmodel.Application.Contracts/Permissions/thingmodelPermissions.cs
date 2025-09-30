using Volo.Abp.Reflection;

namespace ttshang.thingmodel.Permissions;

public class thingmodelPermissions
{
    public const string GroupName = "thingmodel";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(thingmodelPermissions));
    }
}
