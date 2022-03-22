using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ChildTest.Data;

/* This is used if database provider does't define
 * IChildTestDbSchemaMigrator implementation.
 */
public class NullChildTestDbSchemaMigrator : IChildTestDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
