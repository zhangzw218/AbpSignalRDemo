
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace EFCoreNull.Repo
{
    public class AppUser : IUser
    {
        public string? UserName { get; set; }

        public string? Email { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public bool IsActive { get; set; }

        public bool EmailConfirmed { get; set; }

        public string? PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public Guid Id { get; set; }

        public Guid? TenantId { get; set; }

        public object[] GetKeys()
        {
            return new List<object> { Id }.ToArray();
        }
    }
}
