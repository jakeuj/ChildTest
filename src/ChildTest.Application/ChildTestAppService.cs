using System;
using System.Collections.Generic;
using System.Text;
using ChildTest.Localization;
using Volo.Abp.Application.Services;

namespace ChildTest;

/* Inherit your application services from this class.
 */
public abstract class ChildTestAppService : ApplicationService
{
    protected ChildTestAppService()
    {
        LocalizationResource = typeof(ChildTestResource);
    }
}
