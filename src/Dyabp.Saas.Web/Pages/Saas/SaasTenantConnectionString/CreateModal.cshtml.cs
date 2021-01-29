using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dyabp.Saas;
using Dyabp.Saas.Dtos;
using Dyabp.Saas.Web.Pages.Saas.SaasTenantConnectionString.ViewModels;

namespace Dyabp.Saas.Web.Pages.Saas.SaasTenantConnectionString
{
    public class CreateModalModel : SaasPageModel
    {
        [BindProperty]
        public CreateSaasTenantConnectionStringViewModel ViewModel { get; set; }

        private readonly ISaasTenantConnectionStringAppService _service;

        public CreateModalModel(ISaasTenantConnectionStringAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateSaasTenantConnectionStringViewModel, CreateSaasTenantConnectionStringDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}