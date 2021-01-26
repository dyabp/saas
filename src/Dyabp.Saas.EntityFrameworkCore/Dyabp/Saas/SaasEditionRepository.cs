using System;
using Dyabp.Saas.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Dyabp.Saas
{
    public class SaasEditionRepository : EfCoreRepository<ISaasDbContext, SaasEdition, Guid>, ISaasEditionRepository
    {
        public SaasEditionRepository(IDbContextProvider<ISaasDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}