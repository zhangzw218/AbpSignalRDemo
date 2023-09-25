using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MigrationDemo.Data
{
    /* This is used if database provider does't define
     * IMigrationDemoDbSchemaMigrator implementation.
     */
    public class NullMigrationDemoDbSchemaMigrator : IMigrationDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}