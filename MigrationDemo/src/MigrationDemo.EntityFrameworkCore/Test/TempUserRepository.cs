using System;
using System.Linq;
using System.Threading.Tasks;
using MigrationDemo.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MigrationDemo.Test;

public class TempUserRepository : EfCoreRepository<MigrationDemoDbContext, TempUser, Guid>, ITempUserRepository
{
    public TempUserRepository(IDbContextProvider<MigrationDemoDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<TempUser>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}