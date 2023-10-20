using EFCoreNull.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.Uow;

namespace EFCoreNull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IAbpLazyServiceProvider _abpLazyServiceProvider { get; }
        public WeatherForecastController(IAbpLazyServiceProvider abpLazyServiceProvider)
        {
            _abpLazyServiceProvider = abpLazyServiceProvider;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        [UnitOfWork]
        public async Task<object> GetAsync()
        {
            var uowManager = _abpLazyServiceProvider.GetRequiredService<IUnitOfWorkManager>();
            using(var uow = uowManager.Begin())
            {
                var userRepo = _abpLazyServiceProvider.GetRequiredService<IRepository<IdentityUser>>();
                var userQuery = await userRepo.GetQueryableAsync();
                var user = await userQuery.FirstAsync();


                var appUserRepo = _abpLazyServiceProvider.GetRequiredService<IRepository<AppUser>>();
                var appUserQuery = await appUserRepo.GetQueryableAsync();
                var appUser2 = await appUserQuery.AsNoTracking().FirstAsync();
                var appUser = await appUserQuery.FirstAsync();

                return new
                {
                    UserCount = userQuery.Count(),
                    UserId = user.Id,
                    AppUserCount = appUserQuery.Count(),
                    AppUserId = appUser.Id,
                    DateTime = DateTime.Now
                };
            }
        }
    }
}