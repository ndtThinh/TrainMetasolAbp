using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TrainMetasolAbp.Data;
using Volo.Abp.DependencyInjection;

namespace TrainMetasolAbp.EntityFrameworkCore;

public class EntityFrameworkCoreTrainMetasolAbpDbSchemaMigrator
    : ITrainMetasolAbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTrainMetasolAbpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the TrainMetasolAbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TrainMetasolAbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
