using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Dyabp.Saas.Pages
{
    public class IndexModel : SaasPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}