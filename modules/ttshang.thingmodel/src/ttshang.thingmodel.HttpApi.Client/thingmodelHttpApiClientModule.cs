using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ttshang.thingmodel;

[DependsOn(
    typeof(thingmodelApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class thingmodelHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(thingmodelApplicationContractsModule).Assembly,
            thingmodelRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<thingmodelHttpApiClientModule>();
        });

    }
}
