using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ttshang.thingmodel;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(thingmodelDomainSharedModule)
)]
public class thingmodelDomainModule : AbpModule
{

}
