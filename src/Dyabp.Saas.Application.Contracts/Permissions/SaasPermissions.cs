using Volo.Abp.Reflection;

namespace Dyabp.Saas.Permissions
{
    public class SaasPermissions
    {
        public const string GroupName = "Saas";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(SaasPermissions));
        }

        public class SaasEdition
        {
            public const string Default = GroupName + ".SaasEdition";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class SaasTenantConnectionString
        {
            public const string Default = GroupName + ".SaasTenantConnectionString";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class SaasTenant
        {
            public const string Default = GroupName + ".SaasTenant";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}
