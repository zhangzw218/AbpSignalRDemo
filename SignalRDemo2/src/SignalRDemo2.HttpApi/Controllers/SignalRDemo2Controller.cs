using SignalRDemo2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SignalRDemo2.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SignalRDemo2Controller : AbpControllerBase
{
    protected SignalRDemo2Controller()
    {
        LocalizationResource = typeof(SignalRDemo2Resource);
    }
}
