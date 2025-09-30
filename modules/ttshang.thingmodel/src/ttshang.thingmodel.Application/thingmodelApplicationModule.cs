using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace ttshang.thingmodel;

[DependsOn(
    typeof(thingmodelDomainModule),
    typeof(thingmodelApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class thingmodelApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<thingmodelApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<thingmodelApplicationModule>(validate: true);
        });
    }
}
