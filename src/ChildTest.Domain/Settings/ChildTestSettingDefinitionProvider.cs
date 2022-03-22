using Volo.Abp.Settings;

namespace ChildTest.Settings;

public class ChildTestSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ChildTestSettings.MySetting1));
    }
}
