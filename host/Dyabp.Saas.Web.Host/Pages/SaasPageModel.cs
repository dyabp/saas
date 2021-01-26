using Dyabp.Saas.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Dyabp.Saas.Pages
{
    public abstract class SaasPageModel : AbpPageModel
    {
        protected SaasPageModel()
        {
            LocalizationResourceType = typeof(SaasResource);
        }
    }
}