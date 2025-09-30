using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ttshang.thingmodel.EntityFrameworkCore;

[ConnectionStringName(thingmodelDbProperties.ConnectionStringName)]
public interface IthingmodelDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
