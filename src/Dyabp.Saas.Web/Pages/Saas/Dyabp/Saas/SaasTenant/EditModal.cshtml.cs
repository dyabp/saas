using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dyabp.Saas;
using Dyabp.Saas.Dtos;
using Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasTenant.ViewModels;

namespace Dyabp.Saas.Web.Pages.Saas.Dyabp.Saas.SaasTenant
{
    public class EditModalModel : SaasPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public EditSaasTenantViewModel ViewModel { get; set; }

        private readonly ISaasTenantAppService _service;

        public EditModalModel(ISaasTenantAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<SaasTenantDto, EditSaasTenantViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditSaasTenantViewModel, UpdateSaasTenantDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}