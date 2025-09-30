using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ttshang.thingmodel;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class thingmodelInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<thingmodelInstallerModule>();
        });
    }
}
