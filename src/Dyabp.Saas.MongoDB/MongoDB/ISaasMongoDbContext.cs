using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Dyabp.Saas.MongoDB
{
    [ConnectionStringName(SaasDbProperties.ConnectionStringName)]
    public interface ISaasMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
