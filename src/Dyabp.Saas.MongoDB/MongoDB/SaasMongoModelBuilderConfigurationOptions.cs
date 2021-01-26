using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Dyabp.Saas.MongoDB
{
    public class SaasMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public SaasMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}