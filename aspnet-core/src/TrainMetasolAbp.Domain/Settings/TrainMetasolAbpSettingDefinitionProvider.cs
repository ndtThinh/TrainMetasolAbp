using Volo.Abp.Settings;

namespace TrainMetasolAbp.Settings;

public class TrainMetasolAbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TrainMetasolAbpSettings.MySetting1));
    }
}
