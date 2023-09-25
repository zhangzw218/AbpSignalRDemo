using System;
using Volo.Abp.Domain.Repositories;

namespace MigrationDemo.Test;

public interface ITempRoleRepository : IRepository<TempRole, Guid>
{
}
