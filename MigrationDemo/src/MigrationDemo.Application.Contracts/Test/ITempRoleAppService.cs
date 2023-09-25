using System;
using MigrationDemo.Test.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MigrationDemo.Test;


public interface ITempRoleAppService :
    ICrudAppService< 
                TempRoleDto, 
        Guid, 
        PagedAndSortedResultRequestDto,
        CreateUpdateTempRoleDto,
        CreateUpdateTempRoleDto>
{

}