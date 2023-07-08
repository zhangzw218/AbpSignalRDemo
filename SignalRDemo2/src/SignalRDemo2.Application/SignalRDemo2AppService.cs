using System;
using System.Collections.Generic;
using System.Text;
using SignalRDemo2.Localization;
using Volo.Abp.Application.Services;

namespace SignalRDemo2;

/* Inherit your application services from this class.
 */
public abstract class SignalRDemo2AppService : ApplicationService
{
    protected SignalRDemo2AppService()
    {
        LocalizationResource = typeof(SignalRDemo2Resource);
    }
}
