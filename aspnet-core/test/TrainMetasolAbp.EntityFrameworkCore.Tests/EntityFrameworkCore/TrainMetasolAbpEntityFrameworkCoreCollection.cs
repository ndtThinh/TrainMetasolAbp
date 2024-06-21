using Xunit;

namespace TrainMetasolAbp.EntityFrameworkCore;

[CollectionDefinition(TrainMetasolAbpTestConsts.CollectionDefinitionName)]
public class TrainMetasolAbpEntityFrameworkCoreCollection : ICollectionFixture<TrainMetasolAbpEntityFrameworkCoreFixture>
{

}
