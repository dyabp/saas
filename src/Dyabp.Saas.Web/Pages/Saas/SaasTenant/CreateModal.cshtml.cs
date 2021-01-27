using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dyabp.Saas;
using Dyabp.Saas.Dtos;
using Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasTenant.ViewModels;

namespace Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasTenant
{
    public class CreateModalModel : SaasPageModel
    {
        [BindProperty]
        public CreateSaasTenantViewModel ViewModel { get; set; }

        private readonly ISaasTenantAppService _service;

        public CreateModalModel(ISaasTenantAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateSaasTenantViewModel, CreateSaasTenantDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}