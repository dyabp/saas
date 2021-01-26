using System;
using Volo.Abp.Domain.Repositories;

namespace Dyabp.Saas
{
    public interface ISaasTenantRepository : IRepository<SaasTenant, Guid>
    {
    }
}