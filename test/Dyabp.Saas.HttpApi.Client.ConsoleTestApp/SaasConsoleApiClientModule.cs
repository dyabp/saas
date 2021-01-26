using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Dyabp.Saas
{
    [DependsOn(
        typeof(SaasHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class SaasConsoleApiClientModule : AbpModule
    {
        
    }
}
