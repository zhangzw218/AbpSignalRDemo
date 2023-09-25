using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MigrationDemo.Test;

public static class TempUserEfCoreQueryableExtensions
{
    public static IQueryable<TempUser> IncludeDetails(this IQueryable<TempUser> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            // .Include(x => x.xxx) // TODO: AbpHelper generated
            ;
    }
}
