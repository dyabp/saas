using System.Threading.Tasks;

namespace Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasTenant
{
    public class IndexModel : SaasPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
