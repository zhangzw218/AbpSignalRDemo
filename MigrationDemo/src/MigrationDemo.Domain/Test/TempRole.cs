using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MigrationDemo.Test
{
    public class TempRole : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

    protected TempRole()
    {
    }

    public TempRole(
        Guid id,
        string name
    ) : base(id)
    {
        Name = name;
    }
    }
}
