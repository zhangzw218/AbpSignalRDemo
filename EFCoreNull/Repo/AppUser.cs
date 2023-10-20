
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace EFCoreNull.Repo
{
    public class AppUser : AggregateRoot<Guid>, IUser
    {
        public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public bool IsActive { get; set; }

        public bool EmailConfirmed { get; set; }

        public string? PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public Guid? TenantId { get; set; }

    }
}
