using System;
using MigrationDemo.Test.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MigrationDemo.Test;


public class TempRoleAppService : CrudAppService<TempRole, TempRoleDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTempRoleDto, CreateUpdateTempRoleDto>,
    ITempRoleAppService
{

    private readonly ITempRoleRepository _repository;

    public TempRoleAppService(ITempRoleRepository repository) : base(repository)
    {
        _repository = repository;
    }

}
