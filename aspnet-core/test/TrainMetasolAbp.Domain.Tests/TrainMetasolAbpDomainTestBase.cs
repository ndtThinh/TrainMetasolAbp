using Volo.Abp.Modularity;

namespace TrainMetasolAbp;

/* Inherit from this class for your domain layer tests. */
public abstract class TrainMetasolAbpDomainTestBase<TStartupModule> : TrainMetasolAbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
