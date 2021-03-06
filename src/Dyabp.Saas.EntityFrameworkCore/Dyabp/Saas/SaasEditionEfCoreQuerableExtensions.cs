using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Dyabp.Saas
{
    public static class SaasEditionEfCoreQueryableExtensions
    {
        public static IQueryable<SaasEdition> IncludeDetails(this IQueryable<SaasEdition> queryable, bool include = true)
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