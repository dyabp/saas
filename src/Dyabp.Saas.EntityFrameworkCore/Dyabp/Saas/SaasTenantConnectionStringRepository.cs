using System;
using Dyabp.Saas.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Dyabp.Saas
{
    public class SaasTenantConnectionStringRepository : EfCoreRepository<ISaasDbContext, SaasTenantConnectionString>, ISaasTenantConnectionStringRepository
    {
        public SaasTenantConnectionStringRepository(IDbContextProvider<ISaasDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}