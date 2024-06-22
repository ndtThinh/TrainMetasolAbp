using Volo.Abp.Modularity;

namespace TrainMetasolAbp.Admin;

[DependsOn(
    typeof(TrainMetasolAbpAdminHttpApiClientModule),
    typeof(TrainMetasolAbpDomainTestModule)
)]
public class TrainMetasolAbpAdminApplicationTestModule : AbpModule
{

}
