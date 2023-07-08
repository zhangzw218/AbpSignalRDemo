using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SignalRDemo2.Data;

/* This is used if database provider does't define
 * ISignalRDemo2DbSchemaMigrator implementation.
 */
public class NullSignalRDemo2DbSchemaMigrator : ISignalRDemo2DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
