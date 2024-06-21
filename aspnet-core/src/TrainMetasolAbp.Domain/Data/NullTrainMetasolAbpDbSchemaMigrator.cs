using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TrainMetasolAbp.Data;

/* This is used if database provider does't define
 * ITrainMetasolAbpDbSchemaMigrator implementation.
 */
public class NullTrainMetasolAbpDbSchemaMigrator : ITrainMetasolAbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
