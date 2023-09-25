using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MigrationDemo.Test
{
    public class TempUser : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public TempRole TempRole { get; set; }

    protected TempUser()
    {
    }

    public TempUser(
        Guid id,
        string name,
        TempRole tempRole
    ) : base(id)
    {
        Name = name;
        TempRole = tempRole;
    }
    }
}
