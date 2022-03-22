using ChildTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ChildTest;

[DependsOn(
    typeof(ChildTestEntityFrameworkCoreTestModule)
    )]
public class ChildTestDomainTestModule : AbpModule
{

}
