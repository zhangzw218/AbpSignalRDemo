using MigrationDemo.Test;
using MigrationDemo.Test.Dtos;
using AutoMapper;

namespace MigrationDemo
{
    public class MigrationDemoApplicationAutoMapperProfile : Profile
    {
        public MigrationDemoApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
        CreateMap<TempRole, TempRoleDto>();
        CreateMap<CreateUpdateTempRoleDto, TempRole>(MemberList.Source);
        CreateMap<TempUser, TempUserDto>();
        CreateMap<CreateUpdateTempUserDto, TempUser>(MemberList.Source);
        }
    }
}
