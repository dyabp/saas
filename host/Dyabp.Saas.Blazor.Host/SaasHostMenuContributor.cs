using System.Threading.Tasks;
using Dyabp.Saas.Localization;
using Volo.Abp.UI.Navigation;

namespace Dyabp.Saas.Blazor.Host
{
    public class SaasHostMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<SaasResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "Saas.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
