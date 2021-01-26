using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Dyabp.Saas
{
    public static class SaasTenantConnectionStringEfCoreQueryableExtensions
    {
        public static IQueryable<SaasTenantConnectionString> IncludeDetails(this IQueryable<SaasTenantConnectionString> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}