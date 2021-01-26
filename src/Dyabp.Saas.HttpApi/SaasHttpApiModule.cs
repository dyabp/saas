using Localization.Resources.AbpUi;
using Dyabp.Saas.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Dyabp.Saas
{
    [DependsOn(
        typeof(SaasApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class SaasHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(SaasHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<SaasResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
