using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Dyabp.Saas.MongoDB
{
    public static class SaasMongoDbContextExtensions
    {
        public static void ConfigureSaas(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new SaasMongoModelBuilderConfigurationOptions(
                SaasDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}