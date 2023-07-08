using SignalRDemo2.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SignalRDemo2.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class SignalRDemo2PageModel : AbpPageModel
{
    protected SignalRDemo2PageModel()
    {
        LocalizationResourceType = typeof(SignalRDemo2Resource);
    }
}
