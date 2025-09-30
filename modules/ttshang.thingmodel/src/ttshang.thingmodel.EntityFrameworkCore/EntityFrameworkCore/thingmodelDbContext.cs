using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ttshang.thingmodel.EntityFrameworkCore;

[ConnectionStringName(thingmodelDbProperties.ConnectionStringName)]
public class thingmodelDbContext : AbpDbContext<thingmodelDbContext>, IthingmodelDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public thingmodelDbContext(DbContextOptions<thingmodelDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Configurethingmodel();
    }
}
