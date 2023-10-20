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
                return new
                {
                    UserCount = userQuery.Count(),
                    UserId = user.Id,
                    DateTime = DateTime.Now
                };
            }
        }
    }
}