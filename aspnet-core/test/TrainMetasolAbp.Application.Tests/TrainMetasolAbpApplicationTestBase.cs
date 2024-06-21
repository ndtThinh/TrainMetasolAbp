using Volo.Abp.Modularity;

namespace TrainMetasolAbp;

public abstract class TrainMetasolAbpApplicationTestBase<TStartupModule> : TrainMetasolAbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
