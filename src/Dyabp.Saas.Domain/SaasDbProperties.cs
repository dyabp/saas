using Volo.Abp.Data;

namespace Dyabp.Saas
{
    public static class SaasDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Dyabp";

        public static string DbSchema { get; set; } = AbpCommonDbProperties.DbSchema;

        public const string ConnectionStringName = "DyabpSaas";
    }
}
