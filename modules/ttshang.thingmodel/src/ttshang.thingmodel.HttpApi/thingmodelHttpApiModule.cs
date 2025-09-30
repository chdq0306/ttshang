using Localization.Resources.AbpUi;
using ttshang.thingmodel.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace ttshang.thingmodel;

[DependsOn(
    typeof(thingmodelApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class thingmodelHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(thingmodelHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<thingmodelResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
