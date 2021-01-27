using System.Threading.Tasks;
using Dyabp.Saas.Localization;
using Dyabp.Saas.Permissions;
using Volo.Abp.UI.Navigation;

namespace Dyabp.Saas.Web.Menus
{
    public class SaasMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name != StandardMenus.Main)
            {
                return;
            }

            var administrationMenu = context.Menu.GetAdministration();

            var l = context.GetLocalizer<SaasResource>();
            //Add main menu items.

            if (!await context.IsGrantedAsync(SaasPermissions.SaasEdition.Default) &&
                !await context.IsGrantedAsync(SaasPermissions.SaasTenantConnectionString.Default) &&
                !await context.IsGrantedAsync(SaasPermissions.SaasTenant.Default))
            {
                return;
            }

            var saasMenu = new ApplicationMenuItem(
               SaasMenus.Prefix,
               l["Menu:Saas"],
               "/Saas",
               icon: "fa fa-globe"
           );

            administrationMenu.AddItem(saasMenu);

            if (await context.IsGrantedAsync(SaasPermissions.SaasEdition.Default))
            {
                saasMenu.AddItem(
                    new ApplicationMenuItem(SaasMenus.SaasEdition, l["Menu:SaasEdition"], "/Saas/SaasEdition")
                );
            }
            if (await context.IsGrantedAsync(SaasPermissions.SaasTenantConnectionString.Default))
            {
                saasMenu.AddItem(
                    new ApplicationMenuItem(SaasMenus.SaasTenantConnectionString, l["Menu:SaasTenantConnectionString"], "/Saas/SaasTenantConnectionString")
                );
            }
            if (await context.IsGrantedAsync(SaasPermissions.SaasTenant.Default))
            {
                saasMenu.AddItem(
                    new ApplicationMenuItem(SaasMenus.SaasTenant, l["Menu:SaasTenant"], "/Saas/SaasTenant")
                );
            }
        }
    }
}
