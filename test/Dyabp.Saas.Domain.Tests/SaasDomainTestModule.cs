using Dyabp.Saas.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dyabp.Saas
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(SaasEntityFrameworkCoreTestModule)
        )]
    public class SaasDomainTestModule : AbpModule
    {
        
    }
}
