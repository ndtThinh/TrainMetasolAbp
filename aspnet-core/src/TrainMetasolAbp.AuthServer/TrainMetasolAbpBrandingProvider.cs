using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TrainMetasolAbp;

[Dependency(ReplaceServices = true)]
public class TrainMetasolAbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TrainMetasolAbp";
}
