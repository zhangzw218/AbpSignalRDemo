
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace EFCoreNull.Repo
{
    /// <summary>
    /// Entity<Guid> can query data normally
    /// AggregateRoot<Guid>  Value cannot be null. (Parameter 'second')
    /// </summary>
    //public class AppUser : Entity<Guid>
    public class AppUser : AggregateRoot<Guid>
    {
        public string? UserName { get; set; }
    }
}
