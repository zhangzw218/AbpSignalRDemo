using System;
using MigrationDemo.Test.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MigrationDemo.Test;


public class TempUserAppService : CrudAppService<TempUser, TempUserDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTempUserDto, CreateUpdateTempUserDto>,
    ITempUserAppService
{

    private readonly ITempUserRepository _repository;

    public TempUserAppService(ITempUserRepository repository) : base(repository)
    {
        _repository = repository;
    }

}
