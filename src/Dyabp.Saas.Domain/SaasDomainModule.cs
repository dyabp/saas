using Volo.Abp.AutoMapper;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Dyabp.Saas
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(SaasDomainSharedModule),
        typeof(AbpAutoMapperModule)
    )]
    public class SaasDomainModule : AbpModule
    {

    }
}
