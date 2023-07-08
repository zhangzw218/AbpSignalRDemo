using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using SignalRDemo2.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SignalRDemo.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits SignalRDemo.Web.Pages.SignalRDemoPage
     */
    public abstract class SignalRDemoPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<SignalRDemo2Resource> L { get; set; }
    }
}
