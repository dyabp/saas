using Dyabp.Saas.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Dyabp.Saas.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class SaasPageModel : AbpPageModel
    {
        protected SaasPageModel()
        {
            LocalizationResourceType = typeof(SaasResource);
            ObjectMapperContext = typeof(SaasWebModule);
        }
    }
}