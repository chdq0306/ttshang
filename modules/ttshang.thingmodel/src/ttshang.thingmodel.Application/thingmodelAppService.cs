using ttshang.thingmodel.Localization;
using Volo.Abp.Application.Services;

namespace ttshang.thingmodel;

public abstract class thingmodelAppService : ApplicationService
{
    protected thingmodelAppService()
    {
        LocalizationResource = typeof(thingmodelResource);
        ObjectMapperContext = typeof(thingmodelApplicationModule);
    }
}
