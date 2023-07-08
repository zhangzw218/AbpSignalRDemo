using Microsoft.EntityFrameworkCore;
using SignalRDemo2;
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
                b.ToTable(SignalRDemo2Consts.DbTablePrefix + "SignalRTest", SignalRDemo2Consts.DbSchema);
                b.ConfigureByConvention();
            });
        }
    }
}