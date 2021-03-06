using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Dyabp.Saas;

namespace Dyabp.Saas.EntityFrameworkCore
{
    [ConnectionStringName(SaasDbProperties.ConnectionStringName)]
    public class SaasDbContext : AbpDbContext<SaasDbContext>, ISaasDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<SaasEdition> SaasEditions { get; set; }
        public DbSet<SaasTenantConnectionString> SaasTenantConnectionStrings { get; set; }
        public DbSet<SaasTenant> SaasTenants { get; set; }

        public SaasDbContext(DbContextOptions<SaasDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureSaas();
        }
    }
}
