using System;
using Volo.Abp.Domain.Repositories;

namespace MigrationDemo.Test;

public interface ITempUserRepository : IRepository<TempUser, Guid>
{
}
