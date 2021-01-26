using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Dyabp.Saas
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(SaasDomainSharedModule)
    )]
    public class SaasDomainModule : AbpModule
    {

    }
}
