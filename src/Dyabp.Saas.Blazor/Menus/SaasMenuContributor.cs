using System.Threading.Tasks;
using Dyabp.Saas.Localization;
using Dyabp.Saas.Permissions;
using Volo.Abp.UI.Navigation;

namespace Dyabp.Saas.Blazor.Menus
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
            var l = context.GetLocalizer<SaasResource>();
             //Add main menu items.

            if (await context.IsGrantedAsync(SaasPermissions.SaasEdition.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(SaasMenus.SaasEdition, l["Menu:SaasEdition"], "/Saas/Dyabp/Saas/SaasEdition")
                );
            }
            if (await context.IsGrantedAsync(SaasPermissions.SaasTenantConnectionString.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(SaasMenus.SaasTenantConnectionString, l["Menu:SaasTenantConnectionString"], "/Saas/Dyabp/Saas/SaasTenantConnectionString")
                );
            }
        }
    }
}
