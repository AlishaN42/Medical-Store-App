using Volo.Abp.Settings;

namespace Medical.Settings;

public class MedicalSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MedicalSettings.MySetting1));
    }
}
