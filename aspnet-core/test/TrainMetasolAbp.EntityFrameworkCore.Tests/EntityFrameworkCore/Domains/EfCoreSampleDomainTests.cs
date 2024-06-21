using TrainMetasolAbp.Samples;
using Xunit;

namespace TrainMetasolAbp.EntityFrameworkCore.Domains;

[Collection(TrainMetasolAbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TrainMetasolAbpEntityFrameworkCoreTestModule>
{

}
