using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MigrationDemo.Data;
using Volo.Abp.DependencyInjection;

namespace MigrationDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreMigrationDemoDbSchemaMigrator
        : IMigrationDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMigrationDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MigrationDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MigrationDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}