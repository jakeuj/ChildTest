using System.Threading.Tasks;

namespace ChildTest.Data;

public interface IChildTestDbSchemaMigrator
{
    Task MigrateAsync();
}
