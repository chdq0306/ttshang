using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ttshang.thingmodel.EntityFrameworkCore;

[DependsOn(
    typeof(thingmodelDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class thingmodelEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<thingmodelDbContext>(options =>
        {
            options.AddDefaultRepositories<IthingmodelDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
