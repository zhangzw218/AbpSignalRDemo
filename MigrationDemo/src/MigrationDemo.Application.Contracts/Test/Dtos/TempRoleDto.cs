using System;
using Volo.Abp.Application.Dtos;

namespace MigrationDemo.Test.Dtos;

[Serializable]
public class TempRoleDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; }
}