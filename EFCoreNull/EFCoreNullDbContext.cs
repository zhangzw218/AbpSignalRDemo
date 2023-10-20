using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace EFCoreNull
{
    public class EFCoreNullDbContext : AbpDbContext<EFCoreNullDbContext>
    {
        public EFCoreNullDbContext(DbContextOptions<EFCoreNullDbContext> options) : base(options)
        {
        }

    }
}
