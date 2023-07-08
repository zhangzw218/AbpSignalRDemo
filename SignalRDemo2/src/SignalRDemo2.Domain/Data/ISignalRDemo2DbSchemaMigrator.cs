using System.Threading.Tasks;

namespace SignalRDemo2.Data;

public interface ISignalRDemo2DbSchemaMigrator
{
    Task MigrateAsync();
}
