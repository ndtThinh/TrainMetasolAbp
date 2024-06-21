using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TrainMetasolAbp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class TrainMetasolAbpDbContextFactory : IDesignTimeDbContextFactory<TrainMetasolAbpDbContext>
{
    public TrainMetasolAbpDbContext CreateDbContext(string[] args)
    {
        TrainMetasolAbpEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TrainMetasolAbpDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new TrainMetasolAbpDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TrainMetasolAbp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
