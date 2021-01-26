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
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SaasResource>(name);
        }
    }
}