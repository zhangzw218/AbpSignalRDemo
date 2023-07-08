using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace SignalRDemo;
public class SignalRTest :CreationAuditedAggregateRoot<Guid>
{
    public SignalRTest(string name)
    {
        Name = name;
    }

    public string Name { get;private set; }
}
