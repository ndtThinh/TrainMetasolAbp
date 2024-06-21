using System.Threading.Tasks;

namespace TrainMetasolAbp.Data;

public interface ITrainMetasolAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
