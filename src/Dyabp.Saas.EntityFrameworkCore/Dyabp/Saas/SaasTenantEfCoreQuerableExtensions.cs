using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Dyabp.Saas
{
    public static class SaasTenantEfCoreQueryableExtensions
    {
        public static IQueryable<SaasTenant> IncludeDetails(this IQueryable<SaasTenant> queryable, bool include = true)
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