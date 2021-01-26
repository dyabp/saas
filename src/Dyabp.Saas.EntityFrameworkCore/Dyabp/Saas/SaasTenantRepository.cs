using System;
using Dyabp.Saas.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Dyabp.Saas
{
    public class SaasTenantRepository : EfCoreRepository<ISaasDbContext, SaasTenant, Guid>, ISaasTenantRepository
    {
        public SaasTenantRepository(IDbContextProvider<ISaasDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}