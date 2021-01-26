using Dyabp.Saas.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dyabp.Saas
{
    public abstract class SaasController : AbpController
    {
        protected SaasController()
        {
            LocalizationResource = typeof(SaasResource);
        }
    }
}
