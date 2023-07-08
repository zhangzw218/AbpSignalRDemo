using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SignalRDemo2.Data;
using Volo.Abp.DependencyInjection;

namespace SignalRDemo2.EntityFrameworkCore;

public class EntityFrameworkCoreSignalRDemo2DbSchemaMigrator
    : ISignalRDemo2DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSignalRDemo2DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SignalRDemo2DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SignalRDemo2DbContext>()
            .Database
            .MigrateAsync();
    }
}
