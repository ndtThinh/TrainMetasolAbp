using Volo.Abp.Modularity;

namespace TrainMetasolAbp;

[DependsOn(
    typeof(TrainMetasolAbpApplicationModule),
    typeof(TrainMetasolAbpDomainTestModule)
)]
public class TrainMetasolAbpApplicationTestModule : AbpModule
{

}
