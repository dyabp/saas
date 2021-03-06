using Dyabp.Saas;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dyabp.Saas.EntityFrameworkCore
{
    [DependsOn(
        typeof(SaasDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class SaasEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SaasDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<SaasEdition, SaasEditionRepository>();
                options.AddRepository<SaasTenantConnectionString, SaasTenantConnectionStringRepository>();
                options.AddRepository<SaasTenant, SaasTenantRepository>();
            });
        }
    }
}
