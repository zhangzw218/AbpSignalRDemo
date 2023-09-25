using System;
using Volo.Abp.Application.Dtos;

namespace MigrationDemo.Test.Dtos;

[Serializable]
public class TempUserDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; }

    //public TempRole TempRole { get; set; }
}