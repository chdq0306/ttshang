using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace ttshang.thingmodel.Blazor.WebAssembly;

[DependsOn(
    typeof(thingmodelBlazorModule),
    typeof(thingmodelHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class thingmodelBlazorWebAssemblyModule : AbpModule
{

}
