using Microsoft.Extensions.DependencyInjection;
using ttshang.thingmodel.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace ttshang.thingmodel.Blazor;

[DependsOn(
    typeof(thingmodelApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class thingmodelBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<thingmodelBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<thingmodelBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new thingmodelMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(thingmodelBlazorModule).Assembly);
        });
    }
}
