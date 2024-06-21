using Volo.Abp.Modularity;

namespace TrainMetasolAbp;

[DependsOn(
    typeof(TrainMetasolAbpDomainModule),
    typeof(TrainMetasolAbpTestBaseModule)
)]
public class TrainMetasolAbpDomainTestModule : AbpModule
{

}
