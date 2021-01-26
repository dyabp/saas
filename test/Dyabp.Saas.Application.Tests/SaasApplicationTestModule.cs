using Volo.Abp.Modularity;

namespace Dyabp.Saas
{
    [DependsOn(
        typeof(SaasApplicationModule),
        typeof(SaasDomainTestModule)
        )]
    public class SaasApplicationTestModule : AbpModule
    {

    }
}
