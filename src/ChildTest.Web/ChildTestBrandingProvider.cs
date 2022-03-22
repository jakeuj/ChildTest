using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ChildTest.Web;

[Dependency(ReplaceServices = true)]
public class ChildTestBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ChildTest";
}
