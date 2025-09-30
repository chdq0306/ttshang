using ttshang.thingmodel.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ttshang.thingmodel;

public abstract class thingmodelController : AbpControllerBase
{
    protected thingmodelController()
    {
        LocalizationResource = typeof(thingmodelResource);
    }
}
