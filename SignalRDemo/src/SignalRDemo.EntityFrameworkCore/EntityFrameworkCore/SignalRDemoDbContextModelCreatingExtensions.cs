using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SignalRDemo.EntityFrameworkCore
{
    public static class SignalRDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureSignalRDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));


            builder.Entity<SignalRTest>(b =>
            {
                b.ToTable(SignalRDemoConsts.DbTablePrefix + "SignalRTest", SignalRDemoConsts.DbSchema);
                b.ConfigureByConvention();
            });
        }
    }
}