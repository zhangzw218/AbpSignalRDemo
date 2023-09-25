using MigrationDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MigrationDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MigrationDemoPageModel : AbpPageModel
    {
        protected MigrationDemoPageModel()
        {
            LocalizationResourceType = typeof(MigrationDemoResource);
        }
    }
}