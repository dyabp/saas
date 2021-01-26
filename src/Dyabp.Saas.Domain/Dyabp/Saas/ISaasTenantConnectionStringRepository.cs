using System;
using Volo.Abp.Domain.Repositories;

namespace Dyabp.Saas
{
    public interface ISaasTenantConnectionStringRepository : IRepository<SaasTenantConnectionString>
    {
    }
}