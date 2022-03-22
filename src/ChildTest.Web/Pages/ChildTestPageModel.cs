using ChildTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ChildTest.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ChildTestPageModel : AbpPageModel
{
    protected ChildTestPageModel()
    {
        LocalizationResourceType = typeof(ChildTestResource);
    }
}
