using Volo.Abp.Modularity;

namespace ChildTest;

[DependsOn(
    typeof(ChildTestApplicationModule),
    typeof(ChildTestDomainTestModule)
    )]
public class ChildTestApplicationTestModule : AbpModule
{

}
