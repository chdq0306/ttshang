using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace ttshang.thingmodel.EntityFrameworkCore;

[DependsOn(
    typeof(thingmodelApplicationTestModule),
    typeof(thingmodelEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreSqliteModule)
)]
public class thingmodelEntityFrameworkCoreTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAlwaysDisableUnitOfWorkTransaction();

        var sqliteConnection = CreateDatabaseAndGetConnection();

        Configure<AbpDbContextOptions>(options =>
        {
            options.Configure(configurationContext =>
            {
                configurationContext.UseSqlite(sqliteConnection);
            });
        });
    }

    private static SqliteConnection CreateDatabaseAndGetConnection()
    {
        var connection = new SqliteConnection("Data Source=:memory:");
        connection.Open();

        new thingmodelDbContext(
            new DbContextOptionsBuilder<thingmodelDbContext>().UseSqlite(connection).Options
        ).GetService<IRelationalDatabaseCreator>().CreateTables();

        return connection;
    }
}
