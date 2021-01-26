using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Dyabp.Saas
{
    [DependsOn(
        typeof(SaasDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class SaasApplicationContractsModule : AbpModule
    {

    }
}
