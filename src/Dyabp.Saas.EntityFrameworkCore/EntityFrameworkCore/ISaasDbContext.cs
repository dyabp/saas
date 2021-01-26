using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Dyabp.Saas;

namespace Dyabp.Saas.EntityFrameworkCore
{
    [ConnectionStringName(SaasDbProperties.ConnectionStringName)]
    public interface ISaasDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<SaasEdition> SaasEditions { get; set; }
    }
}
