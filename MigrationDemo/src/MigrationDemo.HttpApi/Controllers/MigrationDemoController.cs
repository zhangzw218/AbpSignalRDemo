using MigrationDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MigrationDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MigrationDemoController : AbpController
    {
        protected MigrationDemoController()
        {
            LocalizationResource = typeof(MigrationDemoResource);
        }
    }
}