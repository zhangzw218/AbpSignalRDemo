using System.Threading.Tasks;

namespace MigrationDemo.Data
{
    public interface IMigrationDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
