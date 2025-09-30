using ttshang.thingmodel.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ttshang.thingmodel.Blazor;

public abstract class thingmodelComponentBase : AbpComponentBase
{
    protected thingmodelComponentBase()
    {
        LocalizationResource = typeof(thingmodelResource);
    }
}