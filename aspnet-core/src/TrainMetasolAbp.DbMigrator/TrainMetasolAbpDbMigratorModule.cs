using TrainMetasolAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace TrainMetasolAbp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(TrainMetasolAbpEntityFrameworkCoreModule),
    typeof(TrainMetasolAbpApplicationContractsModule)
    )]
public class TrainMetasolAbpDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "TrainMetasolAbp:"; });
    }
}
