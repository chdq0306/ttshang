using Volo.Abp.Modularity;

namespace ttshang.thingmodel;

[DependsOn(
    typeof(thingmodelApplicationModule),
    typeof(thingmodelDomainTestModule)
    )]
public class thingmodelApplicationTestModule : AbpModule
{

}
