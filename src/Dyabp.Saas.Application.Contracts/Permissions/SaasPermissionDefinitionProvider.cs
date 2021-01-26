using Dyabp.Saas.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dyabp.Saas.Permissions
{
    public class SaasPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SaasPermissions.GroupName, L("Permission:Saas"));

            var saasEditionPermission = myGroup.AddPermission(SaasPermissions.SaasEdition.Default, L("Permission:SaasEdition"));
            saasEditionPermission.AddChild(SaasPermissions.SaasEdition.Create, L("Permission:Create"));
            saasEditionPermission.AddChild(SaasPermissions.SaasEdition.Update, L("Permission:Update"));
            saasEditionPermission.AddChild(SaasPermissions.SaasEdition.Delete, L("Permission:Delete"));

            var saasTenantConnectionStringPermission = myGroup.AddPermission(SaasPermissions.SaasTenantConnectionString.Default, L("Permission:SaasTenantConnectionString"));
            saasTenantConnectionStringPermission.AddChild(SaasPermissions.SaasTenantConnectionString.Create, L("Permission:Create"));
            saasTenantConnectionStringPermission.AddChild(SaasPermissions.SaasTenantConnectionString.Update, L("Permission:Update"));
            saasTenantConnectionStringPermission.AddChild(SaasPermissions.SaasTenantConnectionString.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SaasResource>(name);
        }
    }
}
