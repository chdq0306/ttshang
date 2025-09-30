using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using ttshang.thingmodel.Localization;
using Volo.Abp.Domain;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace ttshang.thingmodel;

[DependsOn(
    typeof(AbpValidationModule),
    typeof(AbpDddDomainSharedModule)
)]
public class thingmodelDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<thingmodelDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<thingmodelResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/thingmodel");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("thingmodel", typeof(thingmodelResource));
        });
    }
}
