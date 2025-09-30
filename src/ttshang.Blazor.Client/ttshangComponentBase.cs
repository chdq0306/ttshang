using ttshang.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ttshang.Blazor.Client;

public abstract class ttshangComponentBase : AbpComponentBase
{
    protected ttshangComponentBase()
    {
        LocalizationResource = typeof(ttshangResource);
    }
}
