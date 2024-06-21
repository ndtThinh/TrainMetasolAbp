using TrainMetasolAbp.Samples;
using Xunit;

namespace TrainMetasolAbp.EntityFrameworkCore.Applications;

[Collection(TrainMetasolAbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TrainMetasolAbpEntityFrameworkCoreTestModule>
{

}
