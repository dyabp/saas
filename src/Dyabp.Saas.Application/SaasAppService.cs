using Dyabp.Saas.Localization;
using Volo.Abp.Application.Services;

namespace Dyabp.Saas
{
    public abstract class SaasAppService : ApplicationService
    {
        protected SaasAppService()
        {
            LocalizationResource = typeof(SaasResource);
            ObjectMapperContext = typeof(SaasApplicationModule);
        }
    }
}
