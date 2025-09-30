using Volo.Abp.Modularity;

namespace ttshang.thingmodel;

[DependsOn(
    typeof(thingmodelDomainModule),
    typeof(thingmodelTestBaseModule)
)]
public class thingmodelDomainTestModule : AbpModule
{

}
