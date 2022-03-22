using ChildTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ChildTest.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ChildTestController : AbpControllerBase
{
    protected ChildTestController()
    {
        LocalizationResource = typeof(ChildTestResource);
    }
}
