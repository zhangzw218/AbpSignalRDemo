using System;
using System.Linq;
using System.Threading.Tasks;
using MigrationDemo.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MigrationDemo.Test;

public class TempRoleRepository : EfCoreRepository<MigrationDemoDbContext, TempRole, Guid>, ITempRoleRepository
{
    public TempRoleRepository(IDbContextProvider<MigrationDemoDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<TempRole>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}