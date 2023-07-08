using SignalRDemo2.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SignalRDemo.EntityFrameworkCore;
public class SignalRTestRepository : EfCoreRepository<SignalRDemo2DbContext, SignalRTest, Guid>, ISignalRTestRepository
{
    public SignalRTestRepository(IDbContextProvider<SignalRDemo2DbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
